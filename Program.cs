using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using  System.Net;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string sss = "185763728";

string str1 = "http://gemtd.ppbizon.com/sm/201901/heros/get/@";
string str2 = idzhuanhuan(sss).ToString();
string url = str1 + str2;
string shuju = huoquwangye(url);
// Console.WriteLine("收到消息是" + shuju);
JObject chuli = (JObject)JsonConvert.DeserializeObject(shuju);
Console.WriteLine(huoquhuabingshuju(sss));

Console.WriteLine(chuli);

static string huoquwangye(string url)
{
    string shuju = "0";
    try
    {

        HttpClient MyWebClient = new();
        try
        {
            var pageData = MyWebClient.GetStringAsync(url).Result; //从指定网站下载数据
            shuju = pageData.ToString();
        }
        catch (Exception e)
        {

        }




    }
    catch (WebException webEx)
    {
        Console.WriteLine(webEx.Message.ToString());
    }
    return shuju;
}
static string shijian(int miaoshu)
{
    string xianzaishijian2 = "0";
    if (miaoshu != -2)
    {
        DateTime xianzaishijian = DateTime.Now;

        xianzaishijian = xianzaishijian.AddSeconds(miaoshu);
         xianzaishijian2 = xianzaishijian.ToString();

    }

    return xianzaishijian2;

}
static string huoqunicheng(string id)
{
    string shuju = "0";
    try
    {

        string str1 = "https://api.opendota.com/api/players/" + id;
        
        string shuju1 = huoquwangye(str1);
        JObject chuli = (JObject)JsonConvert.DeserializeObject(shuju1);
        if(chuli.ToString().Contains("name"))
        {
            shuju = chuli["profile"]["personaname"].ToString();
           
        }

        return shuju;


    }
    catch (WebException webEx)
    {
        Console.WriteLine(webEx.Message.ToString());
        return shuju;
    }

  

}
static long idzhuanhuan(string id)
{

  long temp = long.Parse(id);
    temp = temp + 76561197960265728;
    return temp;
}
static string tihuan(string shuju)
{
    string d = shuju;
    string l = "onduty_hero,当前英雄,hero_id,\r\n英雄,extend,特效款式,_expire,剩余时间（秒）,_finish_count,完成次数,shell,贝壳,ice,冰块,candy,糖果,pet,宠物,pass,通关任务剩余时间（秒）,season,赛季剩余时间（秒）,extend_tool,格子扩展包,a306,回到过去,hero_sea,英雄,common_hero,普通 英雄,rare_hero,稀有 英雄,mythical_hero,神话 英雄,legendary_hero,传说 英雄,common_ability,普通 英雄技能,rare_ability,稀有 英雄技能,mythical_ability,神话 英雄技能,legendary_ability,传说 英雄技能,common_effect,普通 英雄特效,rare_effect,稀有 英雄特效,mythical_effect,神话 英雄特效,legendary_effect,传说 英雄特效,luckybox,一箱好东西?,buy,购买!,b201607,卡尔幸运箱,a101,回春,a102,闪避,a103,守护,a104,石头,a201,蓝色祈祷,a202,蛋白祈祷,a203,白色祈祷,a204,红色祈祷,a205,绿色祈祷,a206,海浪祈祷,a207,黄色祈祷,a208,紫色祈祷,a209,精英祈祷,a301,快速射击,a302,暴击,a303,瞄准,a304,风暴之锤,a401,移形换位,a210,普通许愿,a305,无暇许愿,a402,完美许愿,b201608,卡尔幸运箱,a105,背水一战,a211,乾坤小挪移,a307,致命链接,q101,不合成白银完成全部关卡。,q102,不合成孔雀石完成全部关卡。,q103,不合成星彩红宝石完成全部关卡。,q104,击杀小飞象Zard-并完成全部关卡。,q105,60分钟内完成全部关卡。,q106,没有一回合合成任何塔完成全部关卡。,q107,宝石城堡满血完成全部关卡。,q108,合出任意隐藏塔并完成全部关卡。,q201,不合成玉完成全部关卡。,q202,不保留钻石完成全部关卡。,q203,不保留蓝宝石完成全部关卡。,q204,不保留红宝石完成全部关卡。,q205,不保留黄玉完成全部关卡。,q206,不保留紫晶完成全部关卡。,q207,不保留海晶石完成全部关卡。,q208,不保留翡翠完成全部关卡。,q209,50分钟内完成全部关卡。,q301,不合成深海珍珠完成全部关卡。,q302,40分钟内完成全部关卡。,q303,击杀黄金肉山宝宝并完成全部关卡。,e101,圣洁精华,e102,玛瑙光泽,e103,芳晓之庆,e104,水晶裂痕,e105,腐化触须,e106,毒虫肆虐,e107,夜魇暗潮腐化,e108,夜魇暗潮荒芜,e201,暗淡幻象,e202,冥魂大帝,e203,翡翠外质,e204,祸乱之源,e205,毒蕈之径,e206,2012冠军之辉,e207,2013冠军之辉,e208,2014冠军之辉,e301,骄阳之炎,e302,嬉戏蝴蝶,e303,冰女特效,e304,幸福之赐,e305,绽放莲花,e306,迎霜冰雪,e307,燃烧末日,e308,鱼泡泡,e401,燃焰之触,e402,霜寒之触,e403,迈达斯之触,e404,离子之汽,e109,大地灵气,e110,蓝色风暴,e309,紫色激情,e310,白雪飘零,e311,一股邪火,e209,霓虹蝴蝶,e210,旋转火花,e312,金币飞舞,e313,光辉岁月,e314,紫色星云,e315,噩梦缠绕,e111,一起哈啤,e112,宝石光泽,e211,雾气环绕,e212,迷幻缠绕,e405,光芒万丈,e316,星星,e113,污污污污,e499,金龙鱼,e114,雾里看花,e317,心心相印,e318,2017冠军之辉,e319,灿若繁星,e320,大漩涡,e407,飞沙走石,e406,星光蓝宝石,e409,血之环,e408,暗月来袭,a403,糖果道标,q109,任意关卡的敌人数量超过20并完成全部关卡。,q110,合成任意闪亮的石板并完成全部关卡。,q210,合成任意超级塔并完成全部关卡。,q211,不使用任何英雄技能完成全部关卡。,q304,升级五个MVP-MAX的塔并完成全部关卡。,e213,小家碧玉,e214,欲火焚身,e321,通灵术,e410,雪精灵,e450,虚无之焰,e451,虚无之焰|红色,e452,虚无之焰|橙色,e453,虚无之焰|黄色,e454,虚无之焰|绿色,e455,虚无之焰|青色,e456,虚无之焰|蓝色,e457,虚无之焰|紫色,e458,虚无之焰|白色,e459,虚无之焰|粉色,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
    string[] n = l.Split(',');
    //    d = "rarity_1,普通";
    int m = 0;
    for (m = 0; m < 307; m++)
    {
        if (d.Contains(n[m]))
        {
            d = d.Replace(n[m], n[m + 1]);
            m++;
        }
    }
    string l1 = "h101,npc_dota_hero_enchantress,h102,npc_dota_hero_puck,h103,npc_dota_hero_omniknight,h104,npc_dota_hero_wisp,h105,npc_dota_hero_ogre_magi,h106,npc_dota_hero_lion,h107,npc_dota_hero_keeper_of_the_light,h108,npc_dota_hero_rubick,h109,npc_dota_hero_jakiro,h110,npc_dota_hero_sand_king,h111,npc_dota_hero_ancient_apparition,h112,npc_dota_hero_earth_spirit,h201,npc_dota_hero_crystal_maiden,h203,npc_dota_hero_templar_assassin,h204,npc_dota_hero_lina,h205,npc_dota_hero_tidehunter,h206,npc_dota_hero_naga_siren,h207,npc_dota_hero_phoenix,h208,npc_dota_hero_dazzle,h209,npc_dota_hero_warlock,h210,npc_dota_hero_necrolyte,h211,npc_dota_hero_lich,h212,npc_dota_hero_furion,h213,npc_dota_hero_venomancer,h214,npc_dota_hero_kunkka,h215,npc_dota_hero_axe,h216,npc_dota_hero_slark,h217,npc_dota_hero_viper,h218,npc_dota_hero_tusk,h219,npc_dota_hero_abaddon,h220,npc_dota_hero_winter_wyvern,h221,npc_dota_hero_ember_spirit,h301,npc_dota_hero_windrunner,h302,npc_dota_hero_phantom_assassin,h303,npc_dota_hero_sniper,h304,npc_dota_hero_sven,h306,npc_dota_hero_mirana,h307,npc_dota_hero_nevermore,h308,npc_dota_hero_queenofpain,h309,npc_dota_hero_juggernaut,h310,npc_dota_hero_pudge,h311,npc_dota_hero_shredder,h312,npc_dota_hero_slardar,h313,npc_dota_hero_antimage,h314,npc_dota_hero_bristleback,h315,npc_dota_hero_lycan,h316,npc_dota_hero_lone_druid,h317,npc_dota_hero_storm_spirit,h318,npc_dota_hero_obsidian_destroyer,h319,npc_dota_hero_grimstroke,h401,npc_dota_hero_vengefulspirit,h402,npc_dota_hero_invoker,h403,npc_dota_hero_alchemist,h404,npc_dota_hero_spectre,h405,npc_dota_hero_morphling,h406,npc_dota_hero_techies,h407,npc_dota_hero_chaos_knight,h408,npc_dota_hero_faceless_void,h409,npc_dota_hero_legion_commander,h410,npc_dota_hero_monkey_king,h411,npc_dota_hero_razor,h412,npc_dota_hero_tinker,h413,npc_dota_hero_pangolier,h414,npc_dota_hero_dark_willow,h415,npc_dota_hero_terrorblade,h416,npc_dota_hero_enigma,t401,奶酪,t402,贪魔蛋,t403,值钱的贝壳,t301,南瓜,t302,雪球,t303,沙滩椅,t304,地渊孢林,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,";
    string[] n1 = l1.Split(',');
    //    d = "rarity_1,普通";
    int m1 = 0;
    for (m1 = 0; m1 < 151; m1++)
    {
        if (d.Contains(n1[m1]))
        {
            d = d.Replace(n1[m1], n1[m1 + 1]);
            m1++;
        }
    }
    string l2 = "common_toy,普通 玩具,rare_toy,稀有 玩具,mythical_toy,神话 玩具,legendary_toy,传说 玩具,npc_dota_hero_enchantress,魅惑魔女,npc_dota_hero_puck,精灵龙,npc_dota_hero_omniknignt,全能骑士,npc_dota_hero_crystal_maiden,水晶室女,npc_dota_hero_templar_assassin,圣堂刺客,npc_dota_hero_lina,秀逗魔导士,npc_dota_hero_windrunner,风行者,npc_dota_hero_phantom_assassin,幻影刺客,npc_dota_hero_sniper,狙击手,npc_dota_hero_vengefulspirit,复仇之魂,npc_dota_hero_sven,流浪剑客,npc_dota_hero_invoker,召唤师,npc_dota_hero_dazzle,暗影牧师,npc_dota_hero_riki,隐形刺客,npc_dota_hero_wisp,精灵守卫,npc_dota_hero_ogre_magi,食人魔法师,npc_dota_hero_lion,恶魔巫师,npc_dota_hero_phoenix,凤凰,npc_dota_hero_necrolyte,死灵法师,npc_dota_hero_lich,巫妖,npc_dota_hero_furion,先知,npc_dota_hero_mirana,月之女祭司,npc_dota_hero_nevermore,影魔,npc_dota_hero_queenofpain,痛苦女王,npc_dota_hero_alchemist,炼金,npc_dota_hero_spectre,幽鬼,npc_dota_hero_omniknight,全能骑士,npc_dota_hero_warlock,术士,npc_dota_hero_keeper_of_the_light,光之守卫,npc_dota_hero_rubick,大魔导师,npc_dota_hero_venomancer,剧毒,npc_dota_hero_kunkka,海军上将,npc_dota_hero_juggernaut,剑圣,npc_dota_hero_pudge,屠夫,npc_dota_hero_shredder,伐木机,npc_dota_hero_morphling,变体精灵,npc_dota_hero_techies,地精工程师,npc_dota_hero_tidehunter,潮汐猎人,npc_dota_hero_naga_siren,娜迦海妖,npc_dota_hero_chaos_knight,混沌骑士,npc_dota_hero_faceless_void,虚空假面,npc_dota_hero_slardar,鱼人守卫,npc_dota_hero_antimage,敌法师,npc_dota_hero_axe,斧王,npc_dota_hero_slark,鱼人夜行者,npc_dota_hero_legion_commander,军团指挥官,npc_dota_hero_jakiro,双头龙,npc_dota_hero_sand_king,沙王,npc_dota_hero_viper,冥界亚龙,npc_dota_hero_tusk,巨牙海民,npc_dota_hero_abaddon,死亡骑士,npc_dota_hero_bristleback,刚背兽,npc_dota_hero_lycan,狼人,npc_dota_hero_lone_druid,利爪德鲁伊,npc_dota_hero_monkey_king,齐天大圣,npc_dota_hero_razor,闪电幽魂,npc_dota_hero_tinker,地精修补匠,npc_dota_hero_dark_willow,邪影芳灵,npc_dota_hero_pangolier,石鳞剑士,npc_dota_hero_ancient_apparition,远古冰魄,npc_dota_hero_earth_spirit,大地之灵,npc_dota_hero_winter_wyvern,寒冬飞龙,npc_dota_hero_ember_spirit,灰烬之灵,npc_dota_hero_storm_spirit,风暴之灵,npc_dota_hero_obsidian_destroyer,殁境神噬者,npc_dota_hero_terrorblade,灵魂守卫,npc_dota_hero_enigma,谜团,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,";
    string[] n2 = l2.Split(',');
    //    d = "rarity_1,普通";
    int m2 = 0;
    for (m2 = 0; m2 < 160; m2++)
    {
        if (d.Contains(n2[m2]))
        {
            d = d.Replace(n2[m2], n2[m2 + 1]);
            m2++;
        }
    }
    d = d.Replace("q399", "丛林挑战");
    d = d.Replace("q398", "暗月来袭");
    d = d.Replace("a308", "乌索尔旋风");
    d = d.Replace("h305", "月之骑土");
    d = d.Replace("h202", "死亡仙知");
    d = d.Replace("q111_", "队伍中带有");
    d = d.Replace("mmr", "\r\n隐藏分");
    d = d.Replace("rankall", "总排位");
    d = d.Replace("rankcoop", "组队排位");
    d = d.Replace("rankrace", "比赛排位");
    d = d.Replace("all_level", "总体等级");
    d = d.Replace("coop_level", "coop等级");
    d = d.Replace("race_level", "race等级");
    d = d.Replace("score", "总排位");
    d = d.Replace("best_kills", "最好成绩：");
    // d = d.Replace("quest:", "\r\n任务");
    d = d.Replace("quest", "\r\n任务");
    d = d.Replace("rank_info", "\r\n排位信息");
    d = d.Replace("user", "\r\n用户id");
    d = d.Replace("match", "\r\n比赛");
    d = d.Replace("word_object", "\r\n赛季信息");
    d = d.Replace("name", "\r\n当前主题");
    d = d.Replace("word_next", "\r\n下季主题");
    d = d.Replace("quest_expire", "\r\n任务剩余时间（秒）");
    d = d.Replace("expire", "\r\n赛季剩余时间（秒）");
    d = d.Replace("items", "\r\n石头饰品");
    return d;
}

static string huoqubaoshishuju(string id)
{
    string shuju2 = "0";

    try
    {

        string str1 = "http://gemtd.ppbizon.com/gemtd/202203/heros/get/@";
        string str2 = idzhuanhuan(id).ToString();
        string url = str1 + str2;
        string shuju = huoquwangye(url);
        // Console.WriteLine("收到消息是" + shuju);
        JObject chuli = (JObject)JsonConvert.DeserializeObject(shuju);
        //   Console.WriteLine("收到消息是chuli" + chuli);
        string beike = chuli["data"][str2]["shell"].ToString();
        string bingkuai = chuli["data"][str2]["ice"].ToString();
        string tangguo = chuli["data"][str2]["candy"].ToString();
        //    Console.WriteLine("收到消息是tangguo" + tangguo);

        string renwu = chuli["data"][str2]["quest"]["quest"].ToString();
        string renwushixian = shijian(int.Parse(chuli["data"][str2]["quest"]["quest_expire"].ToString()));
        string paiming = chuli["data"][str2]["rank_info"]["rankall"].ToString();
        string zuihaochengji = chuli["data"][str2]["rank_info"]["best_kills"].ToString();
        string saijizhuti = chuli["word_object"]["name"].ToString();

        Console.WriteLine("收到消息是" + shuju2);
        shuju2 = tihuan(renwu);
        Console.WriteLine("tihuan(renwu)" + shuju2);
        shuju2 = renwushixian;
        Console.WriteLine("renwushixian" + shuju2);
        shuju2 = zuihaochengji;
        Console.WriteLine("zuihaochengji" + shuju2);
        shuju2 = paiming;
        Console.WriteLine("paiming" + shuju2);
        shuju2 = zuihaochengji;
        Console.WriteLine("chengji" + shuju2);
        shuju2 = huoqunicheng(id);
        Console.WriteLine("nicheng" + shuju2);
        shuju2 = "查询的昵称是：" + huoqunicheng(id) + "\r\n贝壳：" + beike + "冰块：" + bingkuai + "糖果：" + tangguo + "\r\n任务：" + tihuan(renwu) + "\r\n任务时限：" + renwushixian + "\r\n当前排名：" + paiming + "\r\n最好成绩：" + zuihaochengji + "\r\n赛季主题：" + saijizhuti;
        Console.WriteLine("zuihou" + shuju2);
    }
    catch (WebException webEx)
    {
        Console.WriteLine(webEx.Message.ToString());
    }

    return shuju2;

}
static string tihuaner(string shuju)
{
    string d = shuju;
    d = d.Replace("ability", "");
    d = d.Replace("effect", "");
    d = d.Replace("\r\n", "");
    d = d.Replace("\"", "");
    d = d.Replace(" ", "");
    d = d.Replace("{", "");
    d = d.Replace("}", "");
    d = d.Replace(":", "");
    return d;
}
static string huoquhuabingshuju(string id)
{
    string shuju2 = "0";

    try
    {

        string str1 = "http://gemtd.ppbizon.com/sm/201901/heros/get/@";
        string str2 = idzhuanhuan(id).ToString();
        string url = str1 + str2;
        string shuju = huoquwangye(url);
        // Console.WriteLine("收到消息是" + shuju);
        JObject chuli = (JObject)JsonConvert.DeserializeObject(shuju);
        //   Console.WriteLine("收到消息是chuli" + chuli);
        string jiazhao = chuli["data"][str2]["driver"].ToString();
        string bingkuai = chuli["data"][str2]["ice"].ToString();
        string skater_count = chuli["data"][str2]["skater_count"].ToString();
        //    Console.WriteLine("收到消息是tangguo" + tangguo);
        string test = chuli["data"][str2]["task"]["test"].ToString();
        test = shijian(int.Parse(test));
        string cm = chuli["data"][str2]["task"]["cm"].ToString();
        cm = shijian(int.Parse(cm));
        string lina = chuli["data"][str2]["task"]["lina"].ToString();
        lina = shijian(int.Parse(lina));
        string qop = chuli["data"][str2]["task"]["qop"].ToString();
        qop = shijian(int.Parse(qop));
        string ns = chuli["data"][str2]["task"]["ns"].ToString();
        ns = shijian(int.Parse(ns));
        string tinker = chuli["data"][str2]["task"]["tinker"].ToString();
        tinker = shijian(int.Parse(tinker));
        string random = chuli["data"][str2]["task"]["random"].ToString();
        random = shijian(int.Parse(random));
        string season = chuli["data"][str2]["task"]["season"].ToString();
        season = shijian(int.Parse(season));
        string daily = chuli["data"][str2]["task"]["daily"].ToString();
        daily = shijian(int.Parse(daily));
        string rush = chuli["data"][str2]["task"]["rush"].ToString();
        rush = shijian(int.Parse(rush));
        string extend = chuli["data"][str2]["task"]["extend"].ToString();
        extend = shijian(int.Parse(extend));
        string crab_level = chuli["data"][str2]["crab_level"].ToString();
        string crab_season = chuli["data"][str2]["crab_season"].ToString();
        string rank = chuli["data"][str2]["rank"].ToString();
        string count = chuli["data"][str2]["count"].ToString();
        //Console.WriteLine("收到消息是" + shuju2);
        //Console.WriteLine("收到消息是" + shuju2);
        //Console.WriteLine("收到消息是" + shuju2); //Console.WriteLine("收到消息是" + shuju2);
        //shuju2 = tihuan(renwu);
        //Console.WriteLine("收到消息是" + shuju2);
        //Console.WriteLine("收到消息是" + shuju2);
        //Console.WriteLine("收到消息是" + shuju2);
        //Console.WriteLine("收到消息是" + shuju2);
        //Console.WriteLine("收到消息是" + shuju2);

        //Console.WriteLine("tihuan(renwu)" + shuju2);
        //shuju2 = renwushixian;
        //Console.WriteLine("renwushixian" + shuju2);
        //shuju2 = zuihaochengji;
        //Console.WriteLine("zuihaochengji" + shuju2);
        //shuju2 = paiming;
        //Console.WriteLine("paiming" + shuju2);
        //shuju2 = zuihaochengji;
        //Console.WriteLine("chengji" + shuju2);
        //shuju2 = huoqunicheng(id);
        //Console.WriteLine("nicheng" + shuju2);
        shuju2 = "查询的昵称是：" + huoqunicheng(id) + "\r\n驾照等级：" + jiazhao + "冰块：" + bingkuai + "滑冰手数量：" + skater_count + "\r\n驾照任务cd：" +test + "\r\n冰女通关cd：" + cm + "\r\n火女通关cd：" + lina + "\r\n女王通关cd：" +qop + "\r\n夜魔通关cd：" + ns+ "\r\n修补匠通关cd："+ tinker+ "\r\n随机通关cd："+ random+ "\r\n赛季cd：" + season + "\r\n日常通关cd："+ daily + "\r\n英雄难度cd：" + rush + "\r\n英雄任务cd：" + extend + "\r\n日常地图："+ crab_season+":" + crab_level + "\r\n排名：" +rank;
        Console.WriteLine("zuihou" + shuju2);
    }
    catch (WebException webEx)
    {
        Console.WriteLine(webEx.Message.ToString());
    }

    return shuju2;

}
