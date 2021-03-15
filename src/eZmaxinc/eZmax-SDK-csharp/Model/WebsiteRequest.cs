/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.33
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp.Model
{
    /// <summary>
    /// A Website Object
    /// </summary>
    [DataContract]
    public partial class WebsiteRequest :  IEquatable<WebsiteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsiteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteRequest" /> class.
        /// </summary>
        /// <param name="fkiWebsitetypeID">The unique ID of the Websitetype.  Valid values:  |Value|Description| |-|-| |1|Website| |2|Twitter| |3|Facebook| |4|Survey| (required).</param>
        /// <param name="sWebsiteAddress">The URL of the website. (required).</param>
        public WebsiteRequest(int fkiWebsitetypeID = default(int), string sWebsiteAddress = default(string))
        {
            // to ensure "fkiWebsitetypeID" is required (not null)
            if (fkiWebsitetypeID == null)
            {
                throw new InvalidDataException("fkiWebsitetypeID is a required property for WebsiteRequest and cannot be null");
            }
            else
            {
                this.fkiWebsitetypeID = fkiWebsitetypeID;
            }

            // to ensure "sWebsiteAddress" is required (not null)
            if (sWebsiteAddress == null)
            {
                throw new InvalidDataException("sWebsiteAddress is a required property for WebsiteRequest and cannot be null");
            }
            else
            {
                this.sWebsiteAddress = sWebsiteAddress;
            }

        }

        /// <summary>
        /// The unique ID of the Websitetype.  Valid values:  |Value|Description| |-|-| |1|Website| |2|Twitter| |3|Facebook| |4|Survey|
        /// </summary>
        /// <value>The unique ID of the Websitetype.  Valid values:  |Value|Description| |-|-| |1|Website| |2|Twitter| |3|Facebook| |4|Survey|</value>
        [DataMember(Name="fkiWebsitetypeID", EmitDefaultValue=true)]
        public int fkiWebsitetypeID { get; set; }

        /// <summary>
        /// The URL of the website.
        /// </summary>
        /// <value>The URL of the website.</value>
        [DataMember(Name="sWebsiteAddress", EmitDefaultValue=true)]
        public string sWebsiteAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsiteRequest {\n");
            sb.Append("  fkiWebsitetypeID: ").Append(fkiWebsitetypeID).Append("\n");
            sb.Append("  sWebsiteAddress: ").Append(sWebsiteAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebsiteRequest);
        }

        /// <summary>
        /// Returns true if WebsiteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsiteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsiteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiWebsitetypeID == input.fkiWebsitetypeID ||
                    (this.fkiWebsitetypeID != null &&
                    this.fkiWebsitetypeID.Equals(input.fkiWebsitetypeID))
                ) && 
                (
                    this.sWebsiteAddress == input.sWebsiteAddress ||
                    (this.sWebsiteAddress != null &&
                    this.sWebsiteAddress.Equals(input.sWebsiteAddress))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.fkiWebsitetypeID != null)
                    hashCode = hashCode * 59 + this.fkiWebsitetypeID.GetHashCode();
                if (this.sWebsiteAddress != null)
                    hashCode = hashCode * 59 + this.sWebsiteAddress.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
