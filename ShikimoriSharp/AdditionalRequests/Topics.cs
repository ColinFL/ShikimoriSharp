﻿using System;
using Newtonsoft.Json;
using ShikimoriSharp.Bases;
using static ShikimoriSharp.Information.Users;

namespace ShikimoriSharp.AdditionalRequests
{
    public class Topic
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("topic_title")] public string TopicTitle { get; set; }

        [JsonProperty("body")] public string Body { get; set; }

        [JsonProperty("html_body")] public string HtmlBody { get; set; }

        [JsonProperty("html_footer")] public string HtmlFooter { get; set; }

        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("comments_count")] public long CommentsCount { get; set; }

        [JsonProperty("forum")] public Forum Forum { get; set; }

        [JsonProperty("user")] public User User { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("linked_id")] public long LinkedId { get; set; }

        [JsonProperty("linked_type")] public string LinkedType { get; set; }

        [JsonProperty("linked")] public Linked Linked { get; set; }

        [JsonProperty("viewed")] public bool Viewed { get; set; }

        [JsonProperty("last_comment_viewed")] public object LastCommentViewed { get; set; }

        [JsonProperty("event")] public object Event { get; set; }

        [JsonProperty("episode")] public object Episode { get; set; }
    }

    public class Forum
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("position")] public long Position { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("permalink")] public string Permalink { get; set; }

        [JsonProperty("url")] public string Url { get; set; }
    }

    public class Linked
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("russian")] public string Russian { get; set; }

        [JsonProperty("image")] public Image Image { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("kind")] public string Kind { get; set; }

        [JsonProperty("score")] public string Score { get; set; }

        [JsonProperty("status")] public object Status { get; set; }

        [JsonProperty("volumes")] public long Volumes { get; set; }

        [JsonProperty("chapters")] public long Chapters { get; set; }

        [JsonProperty("episodes")] public long Episodes { get; set; }

        [JsonProperty("episodes_aired")] public long EpisodesAired { get; set; }

        [JsonProperty("aired_on")] public object AiredOn { get; set; }

        [JsonProperty("released_on")] public object ReleasedOn { get; set; }
    }
}