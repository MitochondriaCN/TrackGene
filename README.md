# TrackGene

TrackGene是用于CSU悦动青春项目的登山轨迹分析工具，也可自行配置，用于任何符合格式解析要求的项目。

该项目使用.NET 9构建。

## 配置文件

`appsettings.json`是程序主要的配置文件，可按下表说明进行配置。其中所有项的值都是字符串格式，即需要用引号`"`包裹。

注意，不能删去其中任意一项，否则将导致程序无法启动。若想不进行配置而使用默认行为，可将其设为`null`。

| Key                   | 说明 |
| :---------------------| :---|
| `TrackPath`           | 导出的所有轨迹`.csv`的文件夹。|
| `TrackFileNameFormat` | 单个轨迹`.csv`文件的文件名格式。每个文件都需要有一个完整的`id`，使用`{id}`指示。例如：`"record-{id}.csv"`。|
| `RemoteApiUrl`        | 请求导出所有轨迹文件到`TrackPath`的API URL。程序将使用`GET`方法访问该URL，后端应当将所有轨迹文件导出到`TrackPath`。|
| `RemoteApiToken`      | 请求API时携带的Token。该Token将以Query Param的形式自动附着在URL尾部，形式为`?token=xxx`。|