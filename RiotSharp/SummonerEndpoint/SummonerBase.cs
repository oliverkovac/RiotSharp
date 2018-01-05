﻿using Newtonsoft.Json;
using RiotSharp.GameEndpoint;
using RiotSharp.Http;
using RiotSharp.Http.Interfaces;
using RiotSharp.LeagueEndpoint;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiotSharp.Misc;

namespace RiotSharp.SummonerEndpoint
{
    /// <summary>
    /// Class representing the name and id of a Summoner in the API.
    /// </summary>
    public class SummonerBase
    {
        public Region Region { get; set; }

        internal SummonerBase() { }

        internal SummonerBase(string id, string name, Region region)
        {
            Region = region;
            Name = name;
            Id = long.Parse(id);
        }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
