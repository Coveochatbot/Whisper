﻿using System.Collections.Generic;
using WhisperAPI.Models.MLAPI;

namespace WhisperAPI.Services.MLAPI.Facets
{
    public interface IDocumentFacets
    {
        /// <summary>
        /// This method calls MLAPI and returns questions generated from all documents sent
        /// </summary>
        /// <param name="documentsUri">List of documents uri</param>
        /// <returns>Questions generated by MLAPI</returns>
        List<FacetQuestionResult> GetQuestions(IEnumerable<string> documentsUri);
    }
}