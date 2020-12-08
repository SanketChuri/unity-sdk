/**
* (C) Copyright IBM Corp. 2019, 2020.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.Watson.CompareComply.V1.Model
{
    /// <summary>
    /// The contract currencies that are declared in the document.
    /// </summary>
    public class ContractCurrencies
    {
        /// <summary>
        /// The confidence level in the identification of the contract currency.
        /// </summary>
        public class ConfidenceLevelValue
        {
            /// <summary>
            /// Constant HIGH for High
            /// </summary>
            public const string HIGH = "High";
            /// <summary>
            /// Constant MEDIUM for Medium
            /// </summary>
            public const string MEDIUM = "Medium";
            /// <summary>
            /// Constant LOW for Low
            /// </summary>
            public const string LOW = "Low";
            
        }

        /// <summary>
        /// The confidence level in the identification of the contract currency.
        /// Constants for possible values can be found using ContractCurrencies.ConfidenceLevelValue
        /// </summary>
        [JsonProperty("confidence_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfidenceLevel { get; set; }
        /// <summary>
        /// The contract currency.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// The normalized form of the contract currency, which is listed as a string in
        /// [ISO-4217](https://www.iso.org/iso-4217-currency-codes.html) format. This element is optional; it is
        /// returned only if normalized text exists.
        /// </summary>
        [JsonProperty("text_normalized", NullValueHandling = NullValueHandling.Ignore)]
        public string TextNormalized { get; set; }
        /// <summary>
        /// Hashed values that you can send to IBM to provide feedback or receive support.
        /// </summary>
        [JsonProperty("provenance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProvenanceIds { get; set; }
        /// <summary>
        /// The numeric location of the identified element in the document, represented with two integers labeled
        /// `begin` and `end`.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }
    }
}
