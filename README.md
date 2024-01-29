# 使用 .NET 泛型主機建立 Conosle App

使用 [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting) NuGet 套件建立一個使用泛型主機架構的主控台應用程式，.NET 泛型主機負責應用程式啟動和存留期管理。

泛型主機是封裝應用程式資源和存留期功能的物件，基本的管理項目如下：

- 相依性插入 (DI)
- 記錄
- 組態
- 應用程式關閉
- IHostedService 實作

藉由在泛型主機這個單一物件中，管理應用程式中相互依存資源的生命週期，並控制應用程式的啟動及關閉。

## HostBuilder

在 .NET 泛型主機中，提供 `HostApplicationBuilder` 和 `HostBuilder` 兩種建構方法，差別在於構建和配置應用程式主機的不同機制。以下是它們之間主要的差異：

1. 版本和使用情境：
   - `HostBuilder`：這是 .NET Core 3.0 以前引入的機制，用於設定和配置服務、日誌記錄、配置以及其他核心功能
   - `HostApplicationBuilder`：這是在 .NET 6 中引入的，作為 `HostBuilder` 的一個替代品或改進，提供更簡潔和直觀的API來構建和配置應用程式的主機

2. API 風格和易用性：
   - `HostBuilder`：提供了一個靈活但稍微複雜的 API 來手動配置所有服務和組件
   - `HostApplicationBuilder`：旨在提供更現代化和簡化的API體驗。它通過集成更多預設配置來減少樣板程式碼，使得開發者更容易上手

3. 配置方式：
   - `HostBuilder`：需要更多顯式的配置和引導程式碼來設定依賴注入、配置來源、日誌記錄等
   - `HostApplicationBuilder`：通過預設的構建流程和較少的顯式配置，簡化了應用程式啟動和設定過程

4. 目標應用類型：
   - `HostBuilder`：適用於各種類型的 .NET 應用程式，包括控制台、Windows 服務等泛用型應用程式
   - `HostApplicationBuilder`：適用於關注點在應用程式本身，簡化抽象的泛型主機，提供相同的開發集成功能

`HostApplicationBuilder` 是對 `HostBuilder` 的一種簡化，藉由簡化泛型主機的背後行為，將關注點放在構建應用程式，試圖以更簡潔的 API 和更少的配置程式碼來進行開發。而 `HostBuilder` 則提供了更多的靈活性和控制能力，適用於需要細粒度配置的場景。

---

參考資料：

* [MS Learn - .NET 泛型主機](https://learn.microsoft.com/zh-tw/dotnet/core/extensions/generic-host?WT.mc_id=DT-MVP-5003022)
