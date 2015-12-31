using System.Collections.Generic;

namespace TweetThreadInfo.Model
{
    public class ThreadInfo
    {
        public int ThreadStartId { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
