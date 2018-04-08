﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WhisperAPI.Models
{
    public class ConversationContext
    {
        public ConversationContext(Guid chatkey, DateTime datetime)
        {
            this.ChatKey = chatkey;
            this.StartDate = datetime;
            this.SearchQuerries = new List<SearchQuerry>();
            this.SuggestedDocuments = new List<SuggestedDocument>();
        }

        public ConversationContext()
        {
            this.SearchQuerries = new List<SearchQuerry>();
            this.SuggestedDocuments = new List<SuggestedDocument>();
        }

        [Key]
        public Guid ChatKey { get; set; }

        public DateTime StartDate { get; set; }

        public List<SearchQuerry> SearchQuerries { get; set; }

        public List<SuggestedDocument> SuggestedDocuments { get; set; }
    }
}
