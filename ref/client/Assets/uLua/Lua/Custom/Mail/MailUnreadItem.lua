--encoding=utf-8

MailUnreadItem = 
{
	uiName = 'MailUnreadItem',

	-------------------------------------
	data,
	parent,
	isOpen = false,

	-------------------------------------UI
	uiIcon,
	uiTitle,
	uiSender,
	uiSendTime,
	uiAttachment,

	uiButton,
	uiButtonLabel,

	uiDragSV,
};


-----------------------------------------------------------------
--Awake
function MailUnreadItem:Awake()
	local transform = self.transform

	--
	self.uiIcon = transform:FindChild('Icon')
	addOnClick(self.uiIcon.gameObject, self:OnIconClick())
	--����
	self.uiTitle = transform:FindChild('Title'):GetComponent('UILabel')
	--������
	self.uiSender = transform:FindChild('Sender'):GetComponent('UILabel')
	--����ʱ��
	self.uiSendTime = transform:FindChild('SendTime'):GetComponent('UILabel')
	--����
	self.uiAttachment = transform:FindChild('Attachment'):GetComponent('UISprite')
	--self.uiAttachment.text = CommonFunction.GetConstString('STR_CONTAIN_ATTACHMENT')
	--
	self.uiDragSV = transform:GetComponent('UIDragScrollView')
end

--Start
function MailUnreadItem:Start()

end

--Update
function MailUnreadItem:Update( ... )
	-- body
end


-----------------------------------------------------------------
--
function MailUnreadItem:SetData(data)
	--�ʼ�����
	self.data = data

	--����
	self.uiTitle.text = data.title
	--������
	self.uiSender.text = data.sender
	--����ʱ��
	local sendTime = os.date("*t", data.send_time)
	self.uiSendTime.text = sendTime.year .. '-' .. sendTime.month .. '-' .. sendTime.day
	--����
	if not next(data.attachment.attachment) or data.state == MailState.READ_GET or data.state == MailState.READ_WITHOUT then
		self.uiAttachment.gameObject:SetActive(false)
	else
		self.uiAttachment.gameObject:SetActive(true)
	end
end

--
function MailUnreadItem:SetParent(parent)
	self.parent = parent
end

--
function MailUnreadItem:SetDragSV(scrollView)
	self.uiDragSV.scrollView = scrollView
end

--
function MailUnreadItem:OnIconClick()
	return function (go)
		self:OnOperClick(self.gameObject)
	end
end

--
function MailUnreadItem:OnOperClick()
	return function (go)
		if not self.isOpen then
			if self.data.state == MailState.UNREAD then
				local req = {mail_id = self.data.uuid}
				local msg = protobuf.encode("fogs.proto.msg.ReadMail", req)
				LuaHelper.SendPlatMsgFromLua(MsgID.ReadMailID, msg)
				--ע��ظ�������Ϣ
				LuaHelper.RegisterPlatMsgHandler(MsgID.ReadMailRespID, self.parent:ReadMailResp(), self.uiName)
				CommonFunction.ShowWait()
			else
				self.parent:OnOpenMail(self.data, self.data.uuid)
			end
			self.isOpen = true
		end
	end
end
--��ȡ����
function MailUnreadItem:OnGetAttachmentClick( ... )
	return function (go)
		local req = {mail_id = self.data.uuid}
		local msg = protobuf.encode("fogs.proto.msg.GetAttachment", req)
		LuaHelper.SendPlatMsgFromLua(MsgID.GetAttachmentID, msg)
		CommonFunction.ShowWait()
		--ע��ظ�������Ϣ
		LuaHelper.RegisterPlatMsgHandler(MsgID.GetAttachmentRespID, self.parent:GetAttachmentResp(), self.parent.uiName)
	end
end

return MailUnreadItem