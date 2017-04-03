# UWaterlooAPIDotNet

UWaterlooAPIDotNet provides an up-to-date, fully asynchronous and multi-platform wrapper for
the University of Waterloo's API. The library has been built upon .NET Standard 1.3 to allow use
of the wrapper on almost any platform. You can find a compatibilty chart below. 

UWaterlooAPIDotNet uses NodaTime to ensure that dates and times can be compared accurately, due to
.NET's native DateTime object being unable to store specific time zone information. This allows for
dates and times to be converted and usable anywhere, instead of just functioning correctly in Ontario.

The library has been built to provide synchronous and asynchronous methods for every endpoint available,
using the `async / await` pattern provided in recent versions of the .NET Framework, but will also be
compatible in situations where one might find that they may not need asynchronous calls, or it is not]
fully / properly supported.

UWaterlooAPIDotNet follows [Semantic Versioning 2.0.0](http://semver.org/#semantic-versioning-200).

# Compatibility

| Platform | Versions |
| :------- | :------- |
| .NET Standard | 1.3+ |
| .NET Core | 1.0+ |
| .NET Framework | 4.6+ |
| Xamarin (Android/iOS) | 4.1.2+ (VS Plugin) / 6.0.2+ (Studio) |
| Mono (Linux/OSX) | 4.6.0+ |
| Universal Windows Platform | 10.0+ |

# Dependencies

  - [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library/), version 1.6.0+
  - [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/), version 10.0.1+
  - [NodaTime](https://www.nuget.org/packages/NodaTime/), version 2.0.0+
  - [System.Net.Http](https://www.nuget.org/packages/System.Net.Http/), version 4.3.1+

# Usage

To make use of UWaterlooAPIDotNet, you can install it in a number of ways.

  1. Clone this repository and compile yourself. This is for those who are interested in
     bleeding-edge features, however this is not recommended for production use.
  2. Download the available `.nupkg` files from the Releases tab of this repository. This is recommended
     for those who require debug symbols and packages for testing purposes. For those interested only
	 in release builds:
  3. Install the latest version through [NuGet](https://www.nuget.org/packages/UWaterlooAPIDotNet/), 
     via `Install-Package UWaterlooAPIDotNet`.
	 
# Contributing

Refer to [CONTRIBUTING.md](https://github.com/kade-robertson/UWaterlooAPIDotNet/blob/master/.github/CONTRIBUTING.md) for more information.
	 
# License

This project is licensed using the MIT license agreement. View LICENSE.md for more information.
