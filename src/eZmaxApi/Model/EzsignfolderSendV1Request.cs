/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
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
    /// Request for the /1/object/ezsignfolder/{pkiEzsignfolderID}/send API Request
    /// </summary>
    [DataContract]
    public partial class EzsignfolderSendV1Request :  IEquatable<EzsignfolderSendV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderSendV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderSendV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderSendV1Request" /> class.
        /// </summary>
        /// <param name="tExtraMessage">A custom text message that will be added to the email sent to signatories inviting them to sign.  You can send an empty string and only the generic message will be sent. (required).</param>
        public EzsignfolderSendV1Request(string tExtraMessage = default(string))
        {
            // to ensure "tExtraMessage" is required (not null)
            if (tExtraMessage == null)
            {
                throw new InvalidDataException("tExtraMessage is a required property for EzsignfolderSendV1Request and cannot be null");
            }
            else
            {
                this.TExtraMessage = tExtraMessage;
            }

        }

        /// <summary>
        /// A custom text message that will be added to the email sent to signatories inviting them to sign.  You can send an empty string and only the generic message will be sent.
        /// </summary>
        /// <value>A custom text message that will be added to the email sent to signatories inviting them to sign.  You can send an empty string and only the generic message will be sent.</value>
        [DataMember(Name="tExtraMessage", EmitDefaultValue=true)]
        public string TExtraMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderSendV1Request {\n");
            sb.Append("  TExtraMessage: ").Append(TExtraMessage).Append("\n");
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
            return this.Equals(input as EzsignfolderSendV1Request);
        }

        /// <summary>
        /// Returns true if EzsignfolderSendV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderSendV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderSendV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TExtraMessage == input.TExtraMessage ||
                    (this.TExtraMessage != null &&
                    this.TExtraMessage.Equals(input.TExtraMessage))
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
                if (this.TExtraMessage != null)
                    hashCode = hashCode * 59 + this.TExtraMessage.GetHashCode();
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
