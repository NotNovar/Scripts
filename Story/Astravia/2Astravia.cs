//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/Astravia/CoreAstravia.cs
using RBot;

public class CompleteAstraviaLocation
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();
    public CoreAstravia Astravia => new CoreAstravia();
    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        Astravia.Astravia();

        Core.SetOptions(false);
    }
}