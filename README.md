<!-- PROJECT LOGO -->
<div style="text-align: center">
<h1 style="text-align: center">PodcastIndex.Net</h1>

  <a href="https://podcastindex.org">
    <img src="https://podcastindex-org.github.io/docs-api/logo.svg" alt="Logo" >
  </a>

  <p style="text-align: center">
Integrate PodcastIndex API functionalities into your .NET projects with this class library
    <br />
    <a href="https://github.com/pluto-dev/PodcastIndex.Net/issues">Report Bug</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
      <li><a href="#overview">Overview</a></li>
      <li><a href="#installtion">Installation</a></li>
      <li><a href="#getting-started">Getting Started</a></li>
      <li><a href="#available-endpoints">Available Endpoints</a></li>
      <li><a href="#built-with">Built With</a></li>
      <li><a href="#contributing">Contributing</a></li>
      <li><a href="#license">License</a></li>
      <li><a href="#contact">Contact</a></li>
      <li><a href="#acknowledgments">Acknowledgments</a></li>
   </ol>
</details>

## Overview

This is a C# class library that provides easy access to the PodcastIndex API.
The library allows developers to interact with the PodcastIndex API endpoints and retrieve podcast related information.

The Podcast Index API is a powerful service that offers a wide range of functionalities related to podcasting, including
searching for podcasts, retrieving episodes, and much more. To use this library, you'll need a
valid API key from PodcastIndex. If you don't have one yet, you can request it from PodcastIndex.

## Installation

To use this library in your projects, you can download the source code and compile it manually.

Currently there is no nuget packet available.

## Get Started

1. Obtain an API **Key** and **Secret** from [podcastindex.org](https://podcastindex.org/)

2. Add the following to your service collection:

   ```csharp
   services.AddPodcastIndexNet(Configuration);
   ```

   The `Configuration` is the reference to your `IConfiguration`.

3. Update your `appsettings.json`:

   ```json
   {
   "PodcastIndex": {
        "BaseUrl": "https://api.podcastindex.org",
        "UserAgent": "SuperPodcastPlayer/1.3",
        "ApiKey": "YOUR_API_KEY",
        "ApiSecret": "YOU_API_SECRET"
        }
   }
   ```

4. Inject `IPodcastIndex` into your constructor

   ```csharp
   public Test(IPodcastIndex podcastIndex) { }
   ```

5. At last use it like this

   ```csharp
   var searchResponse = await podcastIndex.Search().GetByTermAsync("Batman");
   ```

## Available Endpoints

| **Search**           |   |
|----------------------|---|
| /search/byterm       | ✅ |
| /search/title        | ✅ |
| /search/byperson     | ✅ |
| /search/music/byterm | ✅ |

| **Podcasts**         |   |
|----------------------|---|
| /podcasts/byfeedid   | ✅ |
| /podcasts/byfeedurl  | ✅ |
| /podcasts/byitunesid | ✅ |
| /podcasts/byguid     | ✅ |
| /podcasts/bytag      | ✅ |
| /podcasts/bymedium   | ✅ |
| /podcasts/trending   | ✅ |
| /podcasts/dead       | ✅ |

| **Episodes**            |   |
|-------------------------|---|
| /episodes/byfeedid      | ✅ |
| /episodes/byfeedurl     | ✅ |
| /episodes/bypodcastguid | ✅ |
| /episodes/byitunesid    | ✅ |
| /episodes/byid          | ✅ |
| /episodes/byguid        | ✅ |
| /episodes/live          | ✅ |
| /episodes/random        | ✅ |

| **Recent**            |   |
|-----------------------|---|
| /recent/episodes      | ✅ |
| /recent/feeds         | ✅ |
| /recent/newfeeds      | ✅ |
| /recent/newvaluefeeds | ✅ |
| /recent/data          | ✅ |
| /recent/soundbites    | ✅ |


| **Value**        |   |
|------------------|---|
| /value/byfeedid  | ✅ |
| /value/byfeedurl | ✅ |


| **Stats**       |   |
|-----------------|---|
| /stats/current  | ✅ |

| **Categories**   |   |
|------------------|---|
| /categories/list | ✅ |

| **Hub**        |    |
|----------------|----|
| /hub/pubnotify | ✅ |

| **Apple Replacement** |    |
|-----------------------|----|
| /search               | ✅  |
| /lookup               | ✅  |

| **Add**              |   |
|----------------------|---|
| /add/byfeedurl       | ❌ |
| /add/byitunesid      | ❌ |
| POST /add/byfeedurl  | ❌ |
| POST /add/byitunesid | ❌ |

Please refer to the official [PodcastIndex API documentation](https://podcastindex-org.github.io/docs-api/) for more details on each endpoint.

## Built With

This library makes heavily use of [refit](https://github.com/reactiveui/refit)

![refit logo](https://raw.githubusercontent.com/reactiveui/refit/main/refit_logo.png)

## Contributing

Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also
simply open an issue with the tag "enhancement".

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the [MIT License](https://opensource.org/license/mit/).

## Contact

[https://github.com/pluto-dev](https://github.com/pluto-dev)

## Acknowledgments

Special thanks to the developers at [PodcastIndex](https://podcastindex.org/) for providing this amazing API!
