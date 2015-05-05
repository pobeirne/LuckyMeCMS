﻿using System;
using System.ComponentModel.DataAnnotations;
using LuckyMe.CMS.WebAPI.Attributes;

namespace LuckyMe.CMS.WebAPI.Models
{public class FacebookAlbumViewModel
    {
        [Required]
        [FacebookMapping("id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Album Name")]
        [FacebookMapping("name")]
        public string Name { get; set; }

        [Display(Name = "Photo Count")]
        [FacebookMapping("count")]
        public long Count { get; set; }

        [Display(Name = "Link")]
        [FacebookMapping("link")]
        public string Link { get; set; }

        [FacebookMapping("url", Parent = "picture")]
        public string ImageUrl { get; set; }

        [Display(Name = "LastUpdated")]
        [FacebookMapping("updated_time")]
        public DateTime LastUpdated { get; set; }
    }
}