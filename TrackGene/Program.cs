using System.Reflection;
using System.IO;
using Microsoft.Extensions.Configuration;
using TrackGene.Configuration;


AppConfig appConfig = ConfigManager.GetAppConfig();

if (args.Contains("--help") || args.Contains("-h"))
{
  Console.WriteLine("For more information and help, please visit: https://gitlab.54sher.com/54shenghua/trackgene");
  return;
}
else
{
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

  Console.WriteLine($"TrackPath: {appConfig.TrackPath.GetDisplayValue()}");
}