//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/Legion/CoreLegion.cs
using RBot;

public class SwordMaster
{
    public ScriptInterface Bot => ScriptInterface.Instance;

    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public CoreLegion Legion = new CoreLegion();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        GetSwordMaster();

        Core.SetOptions(false);
    }

    public void GetSwordMaster(bool rankUpClass = true)
    {
        if (Core.CheckInventory("SwordMaster"))
            return;
        
        Legion.FarmLegionToken(2000);
        Core.BuyItem("underworld", 238, "SwordMaster", 1);
        if (rankUpClass)
        {
            Core.JumpWait();
            Bot.Player.EquipItem("Blood Sorceress");
            Farm.IcestormArena(1, rankUpClass: true);
        }
    }
}