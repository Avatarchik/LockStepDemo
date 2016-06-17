--encoding=utf-8

StoreRefreshDetail =
{
	uiName = 'StoreRefreshDetail',
	
	--------------------------
	popupFrame,

	--------------------------
	uiPriceItem,
};


-----------------------------------------------------------------
--Awake
function StoreRefreshDetail:Awake()
	local transform = self.transform

	--����
	local go = CommonFunction.InstantiateObject('Prefab/GUI/PopupFrame3', transform)
	if go == nil then
		Debugger.Log('-- InstantiateObject falied ')
		return
	end
	self.popupFrame = getLuaComponent(go)
	self.popupFrame:SetTitle(CommonFunction.GetConstString('STR_REFRESH'))
	self.popupFrame.showCorner = true
	--�ر�
	self.popupFrame.onClose = self:OnCloseClick()
	--ˢ��
	self.popupFrame.buttonLabels = {getCommonStr('STR_REFRESH')}
	self.popupFrame.buttonHandlers = {self:OnRefreshClick()}

	go = createUI('PriceItem', transform:FindChild('PriceItem').transform)
	self.uiPriceItem = getLuaComponent(go)
end

--Start
function StoreRefreshDetail:Start()

end

--Update
function StoreRefreshDetail:Update( ... )
	-- body
end


-----------------------------------------------------------------
---
function StoreRefreshDetail:Init(config)
	if config.consume_type == 1 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_diamond2'
	elseif config.consume_type == 2 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_gold2'
	elseif config.consume_type == 3 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_honor2'
	elseif config.consume_type == 4 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_hp2'
	elseif config.consume_type == 7 then
		self.uiPriceItem.uiValueIcon.spriteName = 'com_property_prestige2'
	end
	self.uiPriceItem.uiValueNum.text = config.consume
end

--����ر��¼�
function StoreRefreshDetail:OnCloseClick()
	return function (go)
		NGUITools.Destroy(self.gameObject)
	end
end

--��������¼�
function StoreRefreshDetail:OnRefreshClick()
	return function (go)
		--���ʹ��̵������
		local refreshStoreGoods = {  
			store_id = UIStore.type,
		}
		local msg = protobuf.encode("fogs.proto.msg.RefreshStoreGoods", refreshStoreGoods)
		LuaHelper.SendPlatMsgFromLua(MsgID.RefreshStoreGoodsID, msg)
		
		UIStore:RegisterRefresh()


		NGUITools.Destroy(self.gameObject)
	end
end


return StoreRefreshDetail
