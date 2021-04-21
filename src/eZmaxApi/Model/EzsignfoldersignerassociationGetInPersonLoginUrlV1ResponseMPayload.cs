/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.42
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
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// Payload for the /1/object/ezsignfoldersignerassociation/getInPersonLoginUrl API Request
    /// </summary>
    [DataContract]
    public partial class EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload :  IEquatable<EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="sLoginUrl">The Url to login to the signing application.    Url will expire after 30 minutes.   (required).</param>
        public EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload(string sLoginUrl = default(string))
        {
            // to ensure "sLoginUrl" is required (not null)
            if (sLoginUrl == null)
            {
                throw new InvalidDataException("sLoginUrl is a required property for EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.SLoginUrl = sLoginUrl;
            }

        }

        /// <summary>
        /// The Url to login to the signing application.    Url will expire after 30 minutes.  
        /// </summary>
        /// <value>The Url to login to the signing application.    Url will expire after 30 minutes.  </value>
        [DataMember(Name="sLoginUrl", EmitDefaultValue=true)]
        public string SLoginUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload {\n");
            sb.Append("  SLoginUrl: ").Append(SLoginUrl).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SLoginUrl == input.SLoginUrl ||
                    (this.SLoginUrl != null &&
                    this.SLoginUrl.Equals(input.SLoginUrl))
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
                if (this.SLoginUrl != null)
                    hashCode = hashCode * 59 + this.SLoginUrl.GetHashCode();
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
