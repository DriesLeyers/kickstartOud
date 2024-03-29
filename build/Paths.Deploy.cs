using static Nuke.Common.IO.PathConstruction;

public partial class Paths
{
    public AbsolutePath DeployCommands => (AbsolutePath)@"E:\bin\custom\Commands";
    public AbsolutePath DeployIntranet => (AbsolutePath)@"E:\Sites\intranet.custom.net";
    public AbsolutePath DeployServer => (AbsolutePath)@"E:\Sites\server.custom.net";
    public AbsolutePath DeployServerExcel => DeployServer / "wwwroot/excel";

    public AbsolutePath[] Deploy => new[]
   {
        DeployCommands,
        DeployServer,
        DeployIntranet
    };
}
