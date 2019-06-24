local class = require("lib.middleclass")
local Base = require('package.majiang3d.module.table3d.view.tablehuangshihh_view_3d')
---@class TableEZhouHHView_3d:TableHuangShiHHView_3d
local TableEZhouHHView_3d = class('tableEZhouHHView_3d', Base)

function TableEZhouHHView_3d:init_config()
    Base.init_config(self)
    self.actionSounds =
    {
        ["1"] = {"chi1"},
        ["2"] = {"peng1"},
        ["3"] = {"gang_bugang"},
        ["4"] = {"gang_angang"},
        ["5"] = {"gang1"},
        ["6"] = {"hu_pihu"},
        ["25"] = {"liangzhongfabai"},
        ["66"] = {"hu_pengpenghu"},
        ["44"] = {"hu_qingyise"},
        ["51"] = {"gang_fachaigang"},
        ["52"] = {"gang_hongzhonggang"},
        ["53"] = {"gang_laizigang"},
        ["54"] = {"hu_gangkai"},
        ["55"] = {"hu_haohuaqidui"},
        ["56"] = {"hu_jiangyise"},
        ["57"] = {"hu_zimoqidui"},
        ["58"] = {"hu_jiepaoqidui"},
        ["59"] = {"hu_menqingzimo"},
        ["61"] = {"hu_ruanmenqingzimo"},
        ["62"] = {"hu_pihu"},
        ["63"] = {"hu_ruanhuzimo"},
        ["64"] = {"hu_yinghujiepao"},
        ["65"] = {"hu_yingzimo"},
        ["31"] = {"zimo"},
        ["33"] = {"hu_pihu"},
    }
end

function TableEZhouHHView_3d:get_hand_tag_type(pai,gameState)
    local tagType = Base.get_hand_tag_type(self,pai,gameState)
    if(pai == 32) then
        tagType = 10
    end
    return tagType
end
function TableEZhouHHView_3d:get_hua_tag_type(pai,gameState)
    local tagType = Base.get_hua_tag_type(self,pai,gameState)
    if(pai == 32) then
        tagType = 10
    end
    return tagType
end
function TableEZhouHHView_3d:get_out_tag_type(pai,gameState)
    local tagType = Base.get_out_tag_type(self,pai,gameState)
    if(pai == 32) then
        tagType = 10
    end
    return tagType
end
function TableEZhouHHView_3d:get_down_tag_type(pai,gameState)
    local tagType = Base.get_down_tag_type(self,pai,gameState)
    if(pai == 32) then
        tagType = 10
    end
    return tagType
end

return TableEZhouHHView_3d