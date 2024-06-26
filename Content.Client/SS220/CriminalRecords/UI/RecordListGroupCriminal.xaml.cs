// © SS220, An EULA/CLA with a hosting restriction, full text: https://raw.githubusercontent.com/SerbiaStrong-220/space-station-14/master/CLA.txt
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.SS220.CriminalRecords.UI;

[GenerateTypedNameReferences]
public sealed partial class RecordListGroupCriminal : RecordListGroup
{
    public RecordListGroupCriminal() : base()
    {
        RobustXamlLoader.Load(this);
        RecordContainer = RecordsBox;
    }

    public override void SetGroupName(string name)
    {
        base.SetGroupName(name);
    }
}
