namespace PodcastIndex.Tests.Responses;

public static class JsonResponses
{
    public static class AppleReplacement
    {
        public const string Search = """
{
  "resultCount": 1,
  "results": [
    {
      "artistName": "Tony Sindelar",
      "artworkUrl100": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "artworkUrl30": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "artworkUrl60": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "artworkUrl600": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "collectionCensoredName": "Batman University",
      "collectionExplicitness": "cleaned",
      "collectionHdPrice": 0,
      "collectionId": 1441923632,
      "collectionName": "Batman University",
      "collectionPrice": 0,
      "collectionViewUrl": "https://podcasts.apple.com/us/podcast/*/id1441923632?uo=4",
      "contentAdvisoryRating": "Clean",
      "country": "USA",
      "currency": "USD",
      "feedUrl": "https://feeds.theincomparable.com/batmanuniversity",
      "genreIds": [
        1309,
        26
      ],
      "genres": [
        "TV & Film",
        "Podcats"
      ],
      "kind": "podcast",
      "primaryGenreName": "string",
      "releaseDate": "2022-10-03T02:17:03-0500",
      "trackCensoredName": "Batman University",
      "trackCount": 12,
      "trackExplicitness": "cleaned",
      "trackHdPrice": 0,
      "trackHdRentalPrice": 0,
      "trackId": 1441923632,
      "trackName": "Batman University",
      "trackPrice": 0,
      "trackRentalPrice": 0,
      "trackViewUrl": "https://podcasts.apple.com/us/podcast/*/id1441923632?uo=4",
      "wrapperType": "track"
    }
  ]
}
""";

        public const string Lookup = """
{
  "resultCount": 1,
  "results": [
    {
      "artistName": "Tony Sindelar",
      "artworkUrl100": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "artworkUrl30": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "artworkUrl60": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "artworkUrl600": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg",
      "collectionCensoredName": "Batman University",
      "collectionExplicitness": "cleaned",
      "collectionHdPrice": 0,
      "collectionId": 1441923632,
      "collectionName": "Batman University",
      "collectionPrice": 0,
      "collectionViewUrl": "https://podcasts.apple.com/us/podcast/*/id1441923632?uo=4",
      "contentAdvisoryRating": "Clean",
      "country": "USA",
      "currency": "USD",
      "feedUrl": "https://feeds.theincomparable.com/batmanuniversity",
      "genreIds": [
        1309,
        26
      ],
      "genres": [
        "TV & Film",
        "Podcats"
      ],
      "kind": "podcast",
      "primaryGenreName": "string",
      "releaseDate": "2022-10-03T02:17:03-0500",
      "trackCensoredName": "Batman University",
      "trackCount": 12,
      "trackExplicitness": "cleaned",
      "trackHdPrice": 0,
      "trackHdRentalPrice": 0,
      "trackId": 1441923632,
      "trackName": "Batman University",
      "trackPrice": 0,
      "trackRentalPrice": 0,
      "trackViewUrl": "https://podcasts.apple.com/us/podcast/*/id1441923632?uo=4",
      "wrapperType": "track"
    }
  ]
}
""";
    }

    public static class Categories
    {
        public const string List = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"id": 2,
			"name": "Books"
		}
	],
	"status": "true"
}
""";
    }

    public static class Episodes
    {
        public const string ByFeedId = """
{
	"count": 1,
	"description": "Found matching feed",
	"items": [
		{
			"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
			"duration": 54,
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"episode": 19,
			"episodeType": "full",
			"explicit": 0,
			"feedDead": 0,
			"feedDuplicateOf": 75075,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"persons": [
				{
					"group": "Cast",
					"href": "https://engineered.network/img/people/dave-jones.jp",
					"id": 411960,
					"img": "https://engineered.network/img/people/dave-jones.jp",
					"name": "Dave Jones",
					"role": "Host"
				}
			],
			"season": 3,
			"socialInteract": [
				{
					"accountId": "@dave",
					"accountUrl": "https://podcastindex.social/users/dave",
					"priority": 0,
					"protocol": "activitypub",
					"url": "https://podcastindex.social/@dave/109762601417741559"
				}
			],
			"soundbite": {
				"duration": 40,
				"startTime": 1123,
				"title": "Why the Podcast Namespace Matters"
			},
			"soundbites": [
				{
					"duration": 40,
					"startTime": 1123,
					"title": "Why the Podcast Namespace Matters"
				}
			],
			"title": "Batman University",
			"transcripts": [
				{
					"type": "application/srt",
					"url": "https://mp3s.nashownotes.com/NA-1385-Captions.srt"
				}
			],
			"transcriptUrl": "https://mp3s.nashownotes.com/NA-1322-Captions.srt",
			"value": {
				"destinations": [
					{
						"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
						"customKey": "112111100",
						"customValue": "wal_ZmqFg13NB31oek",
						"fee": true,
						"name": "podcaster",
						"split": 99,
						"type": "node"
					}
				],
				"model": {
					"method": "keysend",
					"suggested": "0.00000020000",
					"type": "lightning"
				}
			}
		}
	],
	"liveItems": [
		{
			"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
			"contentLink": "string",
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
			"duration": 54,
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"endTime": 1674167400,
			"episode": 19,
			"episodeType": "full",
			"explicit": 0,
			"feedDead": 0,
			"feedDuplicateOf": 75075,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"season": 3,
			"startTime": 1674154800,
			"status": "live",
			"title": "Batman University",
			"transcriptUrl": "https://mp3s.nashownotes.com/NA-1322-Captions.srt"
		}
	],
	"query": "75075",
	"status": "true"
} 
""";

        public const string ByFeedUrl = """
{
	"count": 1,
	"description": "Found matching feed",
	"items": [
		{
			"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
			"duration": 54,
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"episode": 19,
			"episodeType": "full",
			"explicit": 0,
			"feedDead": 0,
			"feedDuplicateOf": 75075,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"persons": [
				{
					"group": "Cast",
					"href": "https://engineered.network/img/people/dave-jones.jp",
					"id": 411960,
					"img": "https://engineered.network/img/people/dave-jones.jp",
					"name": "Dave Jones",
					"role": "Host"
				}
			],
			"season": 3,
			"socialInteract": [
				{
					"accountId": "@dave",
					"accountUrl": "https://podcastindex.social/users/dave",
					"priority": 0,
					"protocol": "activitypub",
					"url": "https://podcastindex.social/@dave/109762601417741559"
				}
			],
			"soundbite": {
				"duration": 40,
				"startTime": 1123,
				"title": "Why the Podcast Namespace Matters"
			},
			"soundbites": [
				{
					"duration": 40,
					"startTime": 1123,
					"title": "Why the Podcast Namespace Matters"
				}
			],
			"title": "Batman University",
			"transcripts": [
				{
					"type": "application/srt",
					"url": "https://mp3s.nashownotes.com/NA-1385-Captions.srt"
				}
			],
			"transcriptUrl": "https://mp3s.nashownotes.com/NA-1322-Captions.srt",
			"value": {
				"destinations": [
					{
						"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
						"customKey": "112111100",
						"customValue": "wal_ZmqFg13NB31oek",
						"fee": true,
						"name": "podcaster",
						"split": 99,
						"type": "node"
					}
				],
				"model": {
					"method": "keysend",
					"suggested": "0.00000020000",
					"type": "lightning"
				}
			}
		}
	],
	"query": {
		"url": "https://feeds.theincomparable.com/batmanuniversity"
	},
	"status": "true"
}
""";

        public const string ByGuid = """
{
	"description": "Found matching feed",
	"episode": {
		"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
		"dateCrawled": 1598369047,
		"datePublished": 1546399813,
		"datePublishedPretty": "January 01, 2019 9:30pm",
		"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
		"duration": 54,
		"enclosureLength": 26385472,
		"enclosureType": "audio/mp3",
		"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
		"episode": 19,
		"episodeType": "full",
		"explicit": 0,
		"feedId": 75075,
		"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"feedImageUrlHash": 1639321931,
		"feedItunesId": 1441923632,
		"feedLanguage": "en-us",
		"feedTitle": "Batman University",
		"guid": "incomparable/batman/19",
		"id": 16795088,
		"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"imageUrlHash": 1639321931,
		"link": "https://www.theincomparable.com/batmanuniversity/",
		"persons": [
			{
				"group": "Cast",
				"href": "https://engineered.network/img/people/dave-jones.jp",
				"id": 411960,
				"img": "https://engineered.network/img/people/dave-jones.jp",
				"name": "Dave Jones",
				"role": "Host"
			}
		],
		"season": 3,
		"socialInteract": [
			{
				"accountId": "@dave",
				"accountUrl": "https://podcastindex.social/users/dave",
				"priority": 0,
				"protocol": "activitypub",
				"url": "https://podcastindex.social/@dave/109762601417741559"
			}
		],
		"soundbite": {
			"duration": 40,
			"startTime": 1123,
			"title": "Why the Podcast Namespace Matters"
		},
		"soundbites": [
			{
				"duration": 40,
				"startTime": 1123,
				"title": "Why the Podcast Namespace Matters"
			}
		],
		"title": "Batman University",
		"transcripts": [
			{
				"type": "application/srt",
				"url": "https://mp3s.nashownotes.com/NA-1385-Captions.srt"
			}
		],
		"value": {
			"destinations": [
				{
					"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
					"customKey": "112111100",
					"customValue": "wal_ZmqFg13NB31oek",
					"fee": true,
					"name": "podcaster",
					"split": 99,
					"type": "node"
				}
			],
			"model": {
				"method": "keysend",
				"suggested": "0.00000020000",
				"type": "lightning"
			}
		}
	},
	"guid": "PC2084",
	"id": "920666",
	"status": "true",
	"url": "http://mp3s.nashownotes.com/pc20rss.xml"
}
""";

        public const string ById = """
{
	"description": "Found matching feed",
	"episode": {
		"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
		"dateCrawled": 1598369047,
		"datePublished": 1546399813,
		"datePublishedPretty": "January 01, 2019 9:30pm",
		"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
		"duration": 54,
		"enclosureLength": 26385472,
		"enclosureType": "audio/mp3",
		"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
		"episode": 19,
		"episodeType": "full",
		"explicit": 0,
		"feedId": 75075,
		"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"feedImageUrlHash": 1639321931,
		"feedItunesId": 1441923632,
		"feedLanguage": "en-us",
		"feedTitle": "Batman University",
		"guid": "incomparable/batman/19",
		"id": 16795088,
		"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"imageUrlHash": 1639321931,
		"link": "https://www.theincomparable.com/batmanuniversity/",
		"persons": [
			{
				"group": "Cast",
				"href": "https://engineered.network/img/people/dave-jones.jp",
				"id": 411960,
				"img": "https://engineered.network/img/people/dave-jones.jp",
				"name": "Dave Jones",
				"role": "Host"
			}
		],
		"season": 3,
		"socialInteract": [
			{
				"accountId": "@dave",
				"accountUrl": "https://podcastindex.social/users/dave",
				"priority": 0,
				"protocol": "activitypub",
				"url": "https://podcastindex.social/@dave/109762601417741559"
			}
		],
		"soundbite": {
			"duration": 40,
			"startTime": 1123,
			"title": "Why the Podcast Namespace Matters"
		},
		"soundbites": [
			{
				"duration": 40,
				"startTime": 1123,
				"title": "Why the Podcast Namespace Matters"
			}
		],
		"title": "Batman University",
		"transcripts": [
			{
				"type": "application/srt",
				"url": "https://mp3s.nashownotes.com/NA-1385-Captions.srt"
			}
		],
		"value": {
			"destinations": [
				{
					"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
					"customKey": "112111100",
					"customValue": "wal_ZmqFg13NB31oek",
					"fee": true,
					"name": "podcaster",
					"split": 99,
					"type": "node"
				}
			],
			"model": {
				"method": "keysend",
				"suggested": "0.00000020000",
				"type": "lightning"
			}
		}
	},
	"id": 16795088,
	"status": "true"
}
""";

        public const string ByItunesId = """
{
	"count": 1,
	"description": "Found matching feed",
	"items": [
		{
			"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
			"duration": 54,
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"episode": 19,
			"episodeType": "full",
			"explicit": 0,
			"feedDead": 0,
			"feedDuplicateOf": 75075,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"persons": [
				{
					"group": "Cast",
					"href": "https://engineered.network/img/people/dave-jones.jp",
					"id": 411960,
					"img": "https://engineered.network/img/people/dave-jones.jp",
					"name": "Dave Jones",
					"role": "Host"
				}
			],
			"season": 3,
			"socialInteract": [
				{
					"accountId": "@dave",
					"accountUrl": "https://podcastindex.social/users/dave",
					"priority": 0,
					"protocol": "activitypub",
					"url": "https://podcastindex.social/@dave/109762601417741559"
				}
			],
			"soundbite": {
				"duration": 40,
				"startTime": 1123,
				"title": "Why the Podcast Namespace Matters"
			},
			"soundbites": [
				{
					"duration": 40,
					"startTime": 1123,
					"title": "Why the Podcast Namespace Matters"
				}
			],
			"title": "Batman University",
			"transcripts": [
				{
					"type": "application/srt",
					"url": "https://mp3s.nashownotes.com/NA-1385-Captions.srt"
				}
			],
			"transcriptUrl": "https://mp3s.nashownotes.com/NA-1322-Captions.srt",
			"value": {
				"destinations": [
					{
						"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
						"customKey": "112111100",
						"customValue": "wal_ZmqFg13NB31oek",
						"fee": true,
						"name": "podcaster",
						"split": 99,
						"type": "node"
					}
				],
				"model": {
					"method": "keysend",
					"suggested": "0.00000020000",
					"type": "lightning"
				}
			}
		}
	],
	"query": "1441923632",
	"status": "true"
}
""";

        /// <summary>
        ///     example is different from the docs, because the one in the docs is wrong
        /// </summary>
        public const string ByPodcastGuid = """
{
	"count": 1,
	"description": "Found matching episodes.",
	"items": [
		{
			"chaptersUrl": null,
			"dateCrawled": 1683285569,
			"datePublished": 1683284235,
			"datePublishedPretty": "May 05, 2023 5:57am",
			"description": "<p>Visit https://podnews.net/update/youtube-disappointment for all the links, and to get our newsletter.</p>\nPodcasting on YouTube is a flop so far, reports Ashley Carman in her newsletter, examining audience numbers for shows from NPR and Slate.</p>\n\nWant some more numbers? The Podnews Daily podcast did 70,427 downloads in April on podcast platforms; and got 653 views on YouTube (an additional 0.9%). More than Spotify, though - it might be the biggest podcast platform by reach, but we had just 492 \"starts\" according to the Spotify for Podcasters dashboard.\n\n\nPodtrac unveiled April 2023's rankers. Vox Media debuted at #10 in the...",
			"duration": 314,
			"enclosureLength": 1972269,
			"enclosureType": "audio/mpeg",
			"enclosureUrl": "https://op3.dev/e,pg=9b024349-ccf0-5f69-a609-6b82873eab3c/podnews.net/audio/podnews230505.mp3?_from=podcastindex.org",
			"episode": 1550,
			"episodeType": "full",
			"explicit": 0,
			"feedDead": 0,
			"feedDuplicateOf": null,
			"feedId": 227573,
			"feedImage": "https://podnews.net/static/podnews-2000x2000.png",
			"feedItunesId": 1325018583,
			"feedLanguage": "en",
			"guid": "https://podnews.net/update/youtube-disappointment",
			"id": 15291344354,
			"image": "https://podnews.net/audio/podnews230505.jpeg",
			"link": "https://podnews.net/update/youtube-disappointment",
			"season": 0,
			"socialInteract": [
				{
					"accountId": "@podnews",
					"accountUrl": "https://social.podnews.net/Podnews",
					"priority": 0,
					"protocol": "activitypub",
					"uri": "https://social.podnews.net/objects/62d3140e-19eb-41d2-85dd-0e4020b3786d"
				}
			],
			"title": "YouTube numbers “not doing so well”",
			"transcripts": [
				{
					"type": "application/srt",
					"url": "https://podnews.net/audio/podnews230505.mp3.srt"
				},
				{
					"type": "text/vtt",
					"url": "https://podnews.net/audio/podnews230505.mp3.vtt"
				}
			],
			"transcriptUrl": "https://podnews.net/audio/podnews230505.mp3.srt"
		}
	],
	"query": 227573,
	"status": "true"
}
""";

        public const string Live = """
{
	"count": 1,
	"description": "Found matching feed",
	"items": [
		{
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"explicit": 0,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"feedTitle": "Batman University",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"title": "Batman University"
		}
	],
	"max": 2,
	"status": "true"
}
""";

        public const string Random = """
{
	"count": 1,
	"description": "Found matching feed",
	"episodes": [
		{
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"chaptersUrl": "https://studio.hypercatcher.com/chapters/podcast/http:feed.nashownotes.comrss.xml/episode/http:1322.noagendanotes.com",
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"episode": 19,
			"episodeType": "full",
			"explicit": 0,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"feedTitle": "Batman University",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"season": 3,
			"title": "Batman University"
		}
	],
	"max": 2,
	"status": "true"
}
""";
    }

    public static class Hub
    {
        public const string PubNotify = """
{
  "status": "true",
  "description": "Found matching feed"
}
""";
    }

    public static class Podcasts
    {
        public const string ByFeedId = """
{
	"description": "Found matching feed",
	"feed": {
		"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"author": "Tony Sindelar",
		"categories": {
			"104": "Tv",
			"105": "Film",
			"107": "Reviews"
		},
		"chash": "ad651c60eaaf3344595c0dd0bd787993",
		"contentType": "application/rss+xml",
		"crawlErrors": 0,
		"dead": 0,
		"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
		"episodeCount": 19,
		"explicit": false,
		"funding": {
			"message": "Pragmatic on Patreon",
			"url": "https://patreon.com/johnchidgey"
		},
		"generator": "my podcast host",
		"id": 75075,
		"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"imageUrlHash": 1639321931,
		"itunesId": 1441923632,
		"itunesType": "episodic",
		"language": "en-us",
		"lastCrawlTime": 1613394034,
		"lastGoodHttpStatusTime": 1613394034,
		"lastHttpStatus": 200,
		"lastParseTime": 1613394045,
		"lastUpdateTime": 1613394044,
		"link": "https://www.theincomparable.com/batmanuniversity/",
		"locked": 0,
		"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
		"ownerName": "The Incomparable",
		"parseErrors": 0,
		"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
		"title": "Batman University",
		"type": 0,
		"url": "https://feeds.theincomparable.com/batmanuniversity",
		"value": {
			"destinations": [
				{
					"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
					"customKey": "112111100",
					"customValue": "wal_ZmqFg13NB31oek",
					"fee": true,
					"name": "podcaster",
					"split": 99,
					"type": "node"
				}
			],
			"model": {
				"method": "keysend",
				"suggested": "0.00000020000",
				"type": "lightning"
			}
		}
	},
	"query": {
		"id": "920666"
	},
	"status": "true"
}
""";

        public const string ByFeedUrl = """
{
	"description": "Found matching feed",
	"feed": {
		"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"author": "Tony Sindelar",
		"categories": {
			"104": "Tv",
			"105": "Film",
			"107": "Reviews"
		},
		"chash": "ad651c60eaaf3344595c0dd0bd787993",
		"contentType": "application/rss+xml",
		"crawlErrors": 0,
		"dead": 0,
		"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
		"episodeCount": 19,
		"explicit": false,
		"funding": {
			"message": "Pragmatic on Patreon",
			"url": "https://patreon.com/johnchidgey"
		},
		"generator": "my podcast host",
		"id": 75075,
		"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"imageUrlHash": 1639321931,
		"itunesId": 1441923632,
		"itunesType": "episodic",
		"language": "en-us",
		"lastCrawlTime": 1613394034,
		"lastGoodHttpStatusTime": 1613394034,
		"lastHttpStatus": 200,
		"lastParseTime": 1613394045,
		"lastUpdateTime": 1613394044,
		"link": "https://www.theincomparable.com/batmanuniversity/",
		"locked": 0,
		"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
		"ownerName": "The Incomparable",
		"parseErrors": 0,
		"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
		"title": "Batman University",
		"type": 0,
		"url": "https://feeds.theincomparable.com/batmanuniversity",
		"value": {
			"destinations": [
				{
					"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
					"customKey": "112111100",
					"customValue": "wal_ZmqFg13NB31oek",
					"fee": true,
					"name": "podcaster",
					"split": 99,
					"type": "node"
				}
			],
			"model": {
				"method": "keysend",
				"suggested": "0.00000020000",
				"type": "lightning"
			}
		}
	},
	"query": {
		"url": "https://feeds.theincomparable.com/batmanuniversity"
	},
	"status": "true"
}
""";

        public const string ByGuid = """
{
	"description": "Found matching feed",
	"feed": {
		"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"author": "Tony Sindelar",
		"categories": {
			"104": "Tv",
			"105": "Film",
			"107": "Reviews"
		},
		"chash": "ad651c60eaaf3344595c0dd0bd787993",
		"contentType": "application/rss+xml",
		"crawlErrors": 0,
		"dead": 0,
		"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
		"episodeCount": 19,
		"explicit": false,
		"funding": {
			"message": "Pragmatic on Patreon",
			"url": "https://patreon.com/johnchidgey"
		},
		"generator": "my podcast host",
		"id": 75075,
		"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"imageUrlHash": 1639321931,
		"itunesId": 1441923632,
		"itunesType": "episodic",
		"language": "en-us",
		"lastCrawlTime": 1613394034,
		"lastGoodHttpStatusTime": 1613394034,
		"lastHttpStatus": 200,
		"lastParseTime": 1613394045,
		"lastUpdateTime": 1613394044,
		"link": "https://www.theincomparable.com/batmanuniversity/",
		"locked": 0,
		"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
		"ownerName": "The Incomparable",
		"parseErrors": 0,
		"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
		"title": "Batman University",
		"type": 0,
		"url": "https://feeds.theincomparable.com/batmanuniversity",
		"value": {
			"destinations": [
				{
					"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
					"customKey": "112111100",
					"customValue": "wal_ZmqFg13NB31oek",
					"fee": true,
					"name": "podcaster",
					"split": 99,
					"type": "node"
				}
			],
			"model": {
				"method": "keysend",
				"suggested": "0.00000020000",
				"type": "lightning"
			}
		}
	},
	"query": {
		"guid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
		"id": "9b024349-ccf0-5f69-a609-6b82873eab3c"
	},
	"status": "true"
}
""";

        public const string ByItunesId = """
{
	"description": "Found matching feed",
	"feed": {
		"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"author": "Tony Sindelar",
		"categories": {
			"104": "Tv",
			"105": "Film",
			"107": "Reviews"
		},
		"contentType": "application/rss+xml",
		"crawlErrors": 0,
		"dead": 0,
		"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
		"episodeCount": 19,
		"funding": {
			"message": "Pragmatic on Patreon",
			"url": "https://patreon.com/johnchidgey"
		},
		"generator": "my podcast host",
		"id": 75075,
		"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
		"itunesId": 1441923632,
		"language": "en-us",
		"lastCrawlTime": 1613394034,
		"lastGoodHttpStatusTime": 1613394034,
		"lastHttpStatus": 200,
		"lastParseTime": 1613394045,
		"lastUpdateTime": 1613394044,
		"link": "https://www.theincomparable.com/batmanuniversity/",
		"locked": 0,
		"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
		"ownerName": "The Incomparable",
		"parseErrors": 0,
		"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
		"title": "Batman University",
		"type": 0,
		"url": "https://feeds.theincomparable.com/batmanuniversity"
	},
	"query": {
		"id": "1441923632"
	},
	"status": "true"
}
""";

        public const string ByMedium = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"author": "Tony Sindelar",
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"contentType": "application/rss+xml",
			"crawlErrors": 0,
			"dead": 0,
			"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
			"episodeCount": 19,
			"explicit": false,
			"generator": "my podcast host",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"imageUrlHash": 1639321931,
			"itunesId": 1441923632,
			"language": "en-us",
			"lastCrawlTime": 1613394034,
			"lastGoodHttpStatusTime": 1613394034,
			"lastHttpStatus": 200,
			"lastParseTime": 1613394045,
			"lastUpdateTime": 1613394044,
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"locked": 0,
			"newestItemPubdate": 1546399813,
			"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
			"ownerName": "The Incomparable",
			"parseErrors": 0,
			"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
			"title": "Batman University",
			"type": 0,
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"medium": "film",
	"status": "true"
}
""";

        public const string ByTagCategoriesIsNull = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"author": "Tony Sindelar",
			"categories": null,
			"contentType": "application/rss+xml",
			"crawlErrors": 0,
			"dead": 0,
			"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
			"funding": {
				"message": "Pragmatic on Patreon",
				"url": "https://patreon.com/johnchidgey"
			},
			"generator": "my podcast host",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"imageUrlHash": 1639321931,
			"itunesId": 1441923632,
			"language": "en-us",
			"lastCrawlTime": 1613394034,
			"lastGoodHttpStatusTime": 1613394034,
			"lastHttpStatus": 200,
			"lastParseTime": 1613394045,
			"lastUpdateTime": 1613394044,
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"locked": 0,
			"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
			"ownerName": "The Incomparable",
			"parseErrors": 0,
			"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
			"popularity": 1,
			"title": "Batman University",
			"type": 0,
			"url": "https://feeds.theincomparable.com/batmanuniversity",
			"value": {
				"destinations": [
					{
						"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
						"customKey": "112111100",
						"customValue": "wal_ZmqFg13NB31oek",
						"fee": true,
						"name": "podcaster",
						"split": 99,
						"type": "node"
					}
				],
				"model": {
					"method": "keysend",
					"suggested": "0.00000020000",
					"type": "lightning"
				}
			},
			"valueCreatedOn": 1598369047
		}
	],
	"nextStartAt": 322043,
	"status": "true",
	"total": 13143
}
""";

        public const string ByTag = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"author": "Tony Sindelar",
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"contentType": "application/rss+xml",
			"crawlErrors": 0,
			"dead": 0,
			"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
			"funding": {
				"message": "Pragmatic on Patreon",
				"url": "https://patreon.com/johnchidgey"
			},
			"generator": "my podcast host",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"imageUrlHash": 1639321931,
			"itunesId": 1441923632,
			"language": "en-us",
			"lastCrawlTime": 1613394034,
			"lastGoodHttpStatusTime": 1613394034,
			"lastHttpStatus": 200,
			"lastParseTime": 1613394045,
			"lastUpdateTime": 1613394044,
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"locked": 0,
			"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
			"ownerName": "The Incomparable",
			"parseErrors": 0,
			"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
			"popularity": 1,
			"title": "Batman University",
			"type": 0,
			"url": "https://feeds.theincomparable.com/batmanuniversity",
			"value": {
				"destinations": [
					{
						"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
						"customKey": "112111100",
						"customValue": "wal_ZmqFg13NB31oek",
						"fee": true,
						"name": "podcaster",
						"split": 99,
						"type": "node"
					}
				],
				"model": {
					"method": "keysend",
					"suggested": "0.00000020000",
					"type": "lightning"
				}
			},
			"valueCreatedOn": 1598369047
		}
	],
	"nextStartAt": 322043,
	"status": "true",
	"total": 13143
}
""";

        public const string Dead = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"duplicateOf": 75075,
			"id": 75075,
			"title": "Batman University",
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"status": "true"
}
""";

        public const string Trending = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"author": "Tony Sindelar",
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"itunesId": 1441923632,
			"language": "en-us",
			"newestItemPublishTime": 1546399813,
			"title": "Batman University",
			"trendScore": 1,
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"max": 2,
	"since": 1613805249,
	"status": "true"
}
""";
    }

    public static class Recent
    {
        public const string Data = """
{
	"data": {
		"feeds": [
			{
				"feedDescription": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
				"feedId": 75075,
				"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
				"feedItunesId": 1441923632,
				"feedLanguage": "en-us",
				"feedTitle": "Batman University",
				"feedUrl": "https://feeds.theincomparable.com/batmanuniversity"
			}
		],
		"items": [
			{
				"episodeAdded": 1613786624,
				"episodeDescription": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
				"episodeDuration": 54,
				"episodeEnclosureLength": 26385472,
				"episodeEnclosureType": "audio/mp3",
				"episodeEnclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
				"episodeId": 16795088,
				"episodeImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
				"episodeTimestamp": 1546399813,
				"episodeTitle": "Batman University",
				"episodeType": "full",
				"feedId": 75075
			}
		],
		"position": 12843054496
	},
	"description": "Found matching feed",
	"feedCount": 1,
	"itemCount": 1,
	"max": 2,
	"nextSince": 1613805249,
	"since": 1613805249,
	"status": "true"
}
""";

        public const string RecentEpisodes = """
{
	"count": 1,
	"description": "Found matching feed",
	"items": [
		{
			"dateCrawled": 1598369047,
			"datePublished": 1546399813,
			"datePublishedPretty": "January 01, 2019 9:30pm",
			"description": "Batman University is back in session! James Thomson and Nathan Alderman join Tony for a discussion of Fox’s “Gotham.” Tune in to hear our thoughts on how a half-baked comic book show was reborn into an unmissable train wreck.",
			"enclosureLength": 26385472,
			"enclosureType": "audio/mp3",
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"episode": 19,
			"episodeType": "full",
			"explicit": 0,
			"feedId": 75075,
			"feedImage": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"feedItunesId": 1441923632,
			"feedLanguage": "en-us",
			"feedTitle": "Batman University",
			"guid": "incomparable/batman/19",
			"id": 16795088,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"season": 3,
			"title": "Batman University"
		}
	],
	"max": 2,
	"status": "true"
}
""";

        public const string Feeds = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"id": 75075,
			"itunesId": 1441923632,
			"language": "en-us",
			"newestItemPublishTime": 1546399813,
			"oldestItemPublishTime": 1546399813,
			"title": "Batman University",
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"max": 2,
	"since": 1613805249,
	"status": "true"
}
""";

        public const string NewFeeds = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"contentHash": "a652d25b56f3e2f0e069c0cc72145a85",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"language": "en-us",
			"status": "confirmed",
			"timeAdded": 1613786624,
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"max": 2,
	"status": "true"
}
""";

        public const string Soundbites = """
{
	"count": 1,
	"description": "Found matching feed",
	"items": [
		{
			"duration": 40,
			"enclosureUrl": "https://www.theincomparable.com/podcast/batmanuniversity302.mp3",
			"episodeId": 16795088,
			"episodeTitle": "Gotham",
			"feedId": 75075,
			"feedTitle": "Batman University",
			"feedUrl": "https://feeds.theincomparable.com/batmanuniversity",
			"startTime": 1123,
			"title": "Why the Podcast Namespace Matters"
		}
	],
	"status": "true"
}
""";
    }

    public static class Search
    {
	    /// <summary>
	    ///     example is different from the docs, because the one in the docs is wrong
	    /// </summary>
	    public const string ByPerson = """
{
	"count": 1,
	"description": "Found matching episodes.",
	"items": [
		{
			"chaptersUrl": "http://34.117.70.159/http%3Afeed.nashownotes.comrss.xml/http:1550.noagendanotes.com",
			"dateCrawled": 1683259498,
			"datePublished": 1682618095,
			"description": "<b>Automatically generated using OpusFeed 1.5 </b><br>Original file : https://op3.dev/e/mp3s.nashownotes.com/NA-1550-2023-04-27-Final.mp3<br><br><h2>No Agenda Episode 1550 - \"Clips of the Day\"</h2>\n\n\n\n<p>\"Clips of the Day\"</p>\n<p>Executive Producers:</p>\n<p>Gustavo Raya</p>\n<p>Adam Curry & John C Dvorak</p>\n<p>Become a member of the 1551 Club, support the show here</p>\n<p>Boost us with with Podcasting 2.0 Certified apps: Podverse - Podfriend - Breez - Sphinx - Podstation - Curiocaster - Fountain</p>\n<p>Art By: Sir Paul Couture</p>\n<p>Engineering, Stream Management & W...",
			"duration": 11683,
			"enclosureLength": 25187383,
			"enclosureType": "audio/opus",
			"enclosureUrl": "https://noagendalite.glump.net/media/NA-1550-2023-04-27-Final.opus",
			"episode": null,
			"episodeType": "full",
			"explicit": 1,
			"feedAuthor": "Adam Curry & John C. Dvorak",
			"feedId": 3756449,
			"feedImage": "https://noagendaassets.com/enc/1683236449.451_1552-art-feed.png",
			"feedItunesId": null,
			"feedLanguage": "en",
			"feedTitle": "No Agenda - OpusFeed",
			"feedUrl": "https://noagendalite.glump.net/noagendalite.rss",
			"guid": "http://1550.noagendanotes.com",
			"id": 15153551036,
			"image": "https://noagendaassets.com/enc/1682456185.185_na-1550-art-feed.png",
			"link": "http://1550.noagendanotes.com",
			"season": 0,
			"title": "1550 - \"Clips of the Day\"",
			"transcripts": [
				{
					"type": "application/srt",
					"url": "https://mp3s.nashownotes.com/NA-1550-Captions.srt"
				}
			],
			"transcriptUrl": null
		}
	],
	"query": "adam curry",
	"status": "true"
}
""";

        public const string ByTerm = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"author": "Tony Sindelar",
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"contentType": "application/rss+xml",
			"crawlErrors": 0,
			"dead": 0,
			"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
			"episodeCount": 19,
			"explicit": false,
			"generator": "my podcast host",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"imageUrlHash": 1639321931,
			"itunesId": 1441923632,
			"language": "en-us",
			"lastCrawlTime": 1613394034,
			"lastGoodHttpStatusTime": 1613394034,
			"lastHttpStatus": 200,
			"lastParseTime": 1613394045,
			"lastUpdateTime": 1613394044,
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"locked": 0,
			"newestItemPubdate": 1546399813,
			"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
			"ownerName": "The Incomparable",
			"parseErrors": 0,
			"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
			"title": "Batman University",
			"type": 0,
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"query": "batman university",
	"status": "true"
}
""";

        public const string ByTitle = """
{
	"count": 1,
	"description": "Found matching feed",
	"feeds": [
		{
			"artwork": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"author": "Tony Sindelar",
			"categories": {
				"104": "Tv",
				"105": "Film",
				"107": "Reviews"
			},
			"contentType": "application/rss+xml",
			"crawlErrors": 0,
			"dead": 0,
			"description": "Batman University is a seasonal podcast about you know who. It began with an analysis of episodes of “Batman: The Animated Series” but has now expanded to cover other series, movies, and media. Your professor is Tony Sindelar.",
			"episodeCount": 19,
			"explicit": false,
			"generator": "my podcast host",
			"id": 75075,
			"image": "https://www.theincomparable.com/imgs/logos/logo-batmanuniversity-3x.jpg?cache-buster=2019-06-11",
			"imageUrlHash": 1639321931,
			"itunesId": 1441923632,
			"language": "en-us",
			"lastCrawlTime": 1613394034,
			"lastGoodHttpStatusTime": 1613394034,
			"lastHttpStatus": 200,
			"lastParseTime": 1613394045,
			"lastUpdateTime": 1613394044,
			"link": "https://www.theincomparable.com/batmanuniversity/",
			"locked": 0,
			"newestItemPubdate": 1546399813,
			"originalUrl": "https://feeds.theincomparable.com/batmanuniversity",
			"ownerName": "The Incomparable",
			"parseErrors": 0,
			"podcastGuid": "9b024349-ccf0-5f69-a609-6b82873eab3c",
			"title": "Batman University",
			"type": 0,
			"url": "https://feeds.theincomparable.com/batmanuniversity"
		}
	],
	"query": "batman university",
	"status": "true"
}
""";

        /// <summary>
        ///     example is different from the docs, because the one in the docs is wrong
        /// </summary>
        public const string MusicByTerm = """
{
	"count": 1,
	"description": "Found matching feeds.",
	"feeds": [
		{
			"artwork": "",
			"author": "Able Kirby",
			"categories": null,
			"contentType": "text/xml",
			"crawlErrors": 0,
			"dead": 0,
			"description": "November EP by Able Kirby",
			"episodeCount": 2,
			"explicit": false,
			"generator": "Bobcat Feeder v1.00",
			"id": 4222574,
			"image": "http://bobcatindex.us-southeast-1.linodeobjects.com/albumart.jpg",
			"imageUrlHash": 2037231565,
			"itunesId": null,
			"language": "en",
			"lastCrawlTime": 1682081623,
			"lastGoodHttpStatusTime": 1682078197,
			"lastHttpStatus": 667,
			"lastParseTime": 1682078296,
			"lastUpdateTime": 1682078234,
			"link": "http://ablekirby.com/",
			"locked": 0,
			"newestItemPubdate": 0,
			"originalUrl": "https://bobcatindex.us-southeast-1.linodeobjects.com/AbleKirby_NovemberEP.xml",
			"ownerName": "",
			"parseErrors": 0,
			"podcastGuid": "7c94197d-0189-55c9-abb0-6dd0b45caeea",
			"title": "November EP",
			"type": 0,
			"url": "https://bobcatindex.us-southeast-1.linodeobjects.com/AbleKirby_NovemberEP.xml"
		}
	],
	"query": "able kirby",
	"status": "true"
}
""";
    }

    public static class Stats
    {
        public const string Current = """
{
	"description": "Found matching feed",
	"stats": {
		"episodeCountTotal": 112890355,
		"feedCountTotal": 4048514,
		"feedsWithNewEpisodes10days": 242922,
		"feedsWithNewEpisodes30days": 352744,
		"feedsWithNewEpisodes3days": 87369,
		"feedsWithNewEpisodes90days": 478568,
		"feedsWithValueBlocks": 9772
	},
	"status": "true"
}
""";
    }

    public static class Value
    {
        public const string ByFeedId = """
{
	"description": "Found matching feed",
	"query": {
		"id": "920666"
	},
	"status": "true",
	"value": {
		"destinations": [
			{
				"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
				"customKey": "112111100",
				"customValue": "wal_ZmqFg13NB31oek",
				"fee": true,
				"name": "podcaster",
				"split": 99,
				"type": "node"
			}
		],
		"model": {
			"method": "keysend",
			"suggested": "0.00000020000",
			"type": "lightning"
		}
	}
}
""";

        public const string ByFeedUrl = """
{
	"description": "Found matching feed",
	"query": {
		"url": "https://feeds.theincomparable.com/batmanuniversity"
	},
	"status": "true",
	"value": {
		"destinations": [
			{
				"address": "03ae9f91a0cb8ff43840e3c322c4c61f019d8c1c3cea15a25cfc425ac605e61a4a",
				"customKey": "112111100",
				"customValue": "wal_ZmqFg13NB31oek",
				"fee": true,
				"name": "podcaster",
				"split": 99,
				"type": "node"
			}
		],
		"model": {
			"method": "keysend",
			"suggested": "0.00000020000",
			"type": "lightning"
		}
	}
}
""";
    }
}