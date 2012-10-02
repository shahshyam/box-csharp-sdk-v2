using Newtonsoft.Json;

namespace BoxApi.V2.Model
{
    /// <summary>
    /// Comments are messages generated by Box users. Each message is tied to specific files or discussions. You can create comments independently or create them as responses to other comments.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Comment : ModifiableEntity
    {
        /// <summary>
        /// Whether or not this comment is a reply to another comment
        /// </summary>
        [JsonProperty(PropertyName = "is_reply_comment")]
        public bool IsReplyComment { get; set; }

        /// <summary>
        /// The comment text
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The object this comment was placed on
        /// </summary>
        public Entity Item { get; set; }
    }
}