using System.Reflection;
using System.IO;
using Microsoft.Extensions.Configuration;
using TrackGene.Configuration;

Console.Write("""


        ,----,
      ,/   .`|                                                ,--.                                  ,--.
    ,`   .'  : ,-.----.       ,---,          ,----..      ,--/  /|   ,----..        ,---,.        ,--.'|     ,---,.
  ;    ;     / \    /  \     '  .' \        /   /   \  ,---,': / '  /   /   \     ,'  .' |    ,--,:  : |   ,'  .' |
.'___,/    ,'  ;   :    \   /  ;    '.     |   :     : :   : '/ /  |   :     :  ,---.'   | ,`--.'`|  ' : ,---.'   |
|    :     |   |   | .\ :  :  :       \    .   |  ;. / |   '   ,   .   |  ;. /  |   |   .' |   :  :  | | |   |   .'
;    |.';  ;   .   : |: |  :  |   /\   \   .   ; /--`  '   |  /    .   ; /--`   :   :  |-, :   |   \ | : :   :  |-,
`----'  |  |   |   |  \ :  |  :  ' ;.   :  ;   | ;     |   ;  ;    ;   | ;  __  :   |  ;/| |   : '  '; | :   |  ;/|
    '   :  ;   |   : .  /  |  |  ;/  \   \ |   : |     :   '   \   |   : |.' .' |   :   .' '   ' ;.    ; |   :   .'
    |   |  '   ;   | |  \  '  :  | \  \ ,' .   | '___  |   |    '  .   | '_.' : |   |  |-, |   | | \   | |   |  |-,
    '   :  |   |   | ;\  \ |  |  '  '--'   '   ; : .'| '   : |.  \ '   ; : \  | '   :  ;/| '   : |  ; .' '   :  ;/|
    ;   |.'    :   ' | \.' |  :  :         '   | '/  : |   | '_\.' '   | '/  .' |   |    \ |   | '`--'   |   |    \
    '---'      :   : :-'   |  | ,'         |   :    /  '   : |     |   :    /   |   :   .' '   : |       |   :   .'
               |   |.'     `--''            \   \ .'   ;   |,'      \   \ .'    |   | ,'   ;   |.'       |   | ,'
               `---'                         `---`     '---'         `---`      `----'     '---'         `----'


""");

Console.WriteLine($"TrackGene {Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "unknown"} by XianlitiCN");

//加载配置
var configBuilder = new ConfigurationBuilder()
  .SetBasePath(Directory.GetCurrentDirectory())
  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfiguration configuration = configBuilder.Build();

AppConfig appConfig = configuration.Get<AppConfig>() ?? new AppConfig();

Console.WriteLine($"TrackPath: {appConfig.TrackPath.GetDisplayValue()}");