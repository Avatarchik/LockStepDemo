-- local function HandleDefend(buf)
-- 	local resp, err = protobuf.decode("fogs.proto.msg.SetDefendResp", buf)
-- 	if resp then
-- 		if resp.result == 0 then
-- 			local role = MainPlayer.Instance.QualifyingInfo.role
-- 			role:Clear()
-- 			for i = 1, 3 do
-- 				local info = RoleInfo.New()
-- 				info.quality = resp.role[i].quality
-- 				info.level = resp.role[i].level
-- 				info.id = resp.role[i].id
-- 				info.star = resp.role[i].star
-- 				--info.quality = resp.role[i].quality
-- 				role:Add(info)
-- 				i = i + 1
-- 			end
-- 		end
-- 	else
-- 		error("UIQualifying:", err) 
-- 	end
-- end

-- LuaHelper.RegisterPlatMsgHandler(MsgID.SetDefendRespID, HandleDefend, "QualifyingHandler")