--encoding=utf-8

HonorCompetitionBuyTimes =
{
	uiName = 'HonorCompetitionBuyTimes',
	
	parent,
	--------------------------
	popupFrame,

	--------------------------
	uiPriceItem,
};


-----------------------------------------------------------------
--Awake
function HonorCompetitionBuyTimes:Awake()
	local transform = self.transform

	--����
	local go = CommonFunction.InstantiateObject('Prefab/GUI/PopupFrame', transform)
	if go == nil then
		Debugger.Log('-- InstantiateObject falied ')
		return
	end
	go.transform.position = Vector3.New(go.transform.position.x, go.transform.position.y, -500)
	self.popupFrame = getLuaComponent(go)
	self.popupFrame:SetTitle(CommonFunction.GetConstString('STR_BUY_TIMES'))
	self.popupFrame.showCorner = true
	--�ر�
	self.popupFrame.onClose = self:OnCloseClick()
	--ȷ��
	self.popupFrame.buttonLabels = {getCommonStr('STR_CONFIRM')}
	self.popupFrame.buttonHandlers = {self:OnConfirmClick()}

	go = createUI('PriceItem', transform:FindChild('PriceItem').transform)
	self.uiPriceItem = getLuaComponent(go)
end

--Start
function HonorCompetitionBuyTimes:Start()

end

--Update
function HonorCompetitionBuyTimes:Update( ... )
	-- body
end


-----------------------------------------------------------------
---
function HonorCompetitionBuyTimes:Init(config)
	if config.consume_type == 1 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_diamond2'
	elseif config.consume_type == 2 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_gold2'
	elseif config.consume_type == 3 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_honor2'
	elseif config.consume_type == 4 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_hp2'
	end
	self.uiPriceItem.uiValueNum.text = config.consume
end

--����ر��¼�
function HonorCompetitionBuyTimes:OnCloseClick()
	return function (go)
		NGUITools.Destroy(self.gameObject)
	end
end

--��������¼�
function HonorCompetitionBuyTimes:OnConfirmClick()
	return function (go)
		--���͹����������
		local req = {  
			type = 'MT_REGULAR',
		}
		local msg = protobuf.encode("fogs.proto.msg.BuyRaceTimesReq", req)
		LuaHelper.SendPlatMsgFromLua(MsgID.BuyRaceTimesReqID, msg)

		NGUITools.Destroy(self.gameObject)
		CommonFunction.ShowWait()
		LuaHelper.RegisterPlatMsgHandler(MsgID.BuyRaceTimesRespID, self:BuyRaceTimesResp(), self.uiName)
	end
end

--
function HonorCompetitionBuyTimes:BuyRaceTimesResp()
	return function (message)
		local resp, err = protobuf.decode('fogs.proto.msg.BuyRaceTimesResp', message)
		CommonFunction.StopWait()
		if resp == nil then
			print('error -- BuyRaceTimesResp error: ', err)
			return
		end
		if resp.result ~= 0 then
			print('error --  BuyRaceTimesResp return failed: ', resp.result)
			CommonFunction.ShowErrorMsg(ErrorID.IntToEnum(resp.result),nil)
			return
		end

		if resp.type == 'MT_REGULAR' then
			MainPlayer.Instance.PvpRunTimes = 0
			MainPlayer.Instance.PvpPointBuyTimes = MainPlayer.Instance.PvpPointBuyTimes + 1
			self.parent:RefreshChallengeTimes()
		end

		--NGUITools.Destroy(self.gameObject)
	end
end


return HonorCompetitionBuyTimes