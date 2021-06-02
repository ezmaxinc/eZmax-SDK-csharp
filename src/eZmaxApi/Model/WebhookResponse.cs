/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.45
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
    /// A webhook object
    /// </summary>
    [DataContract]
    public partial class WebhookResponse :  IEquatable<WebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// The Module generating the Event.
        /// </summary>
        /// <value>The Module generating the Event.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EWebhookModuleEnum
        {
            /// <summary>
            /// Enum Ezsign for value: Ezsign
            /// </summary>
            [EnumMember(Value = "Ezsign")]
            Ezsign = 1,

            /// <summary>
            /// Enum Management for value: Management
            /// </summary>
            [EnumMember(Value = "Management")]
            Management = 2

        }

        /// <summary>
        /// The Module generating the Event.
        /// </summary>
        /// <value>The Module generating the Event.</value>
        [DataMember(Name="eWebhookModule", EmitDefaultValue=true)]
        public EWebhookModuleEnum EWebhookModule { get; set; }
        /// <summary>
        /// This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;.
        /// </summary>
        /// <value>This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EWebhookEzsigneventEnum
        {
            /// <summary>
            /// Enum DocumentCompleted for value: DocumentCompleted
            /// </summary>
            [EnumMember(Value = "DocumentCompleted")]
            DocumentCompleted = 1,

            /// <summary>
            /// Enum FolderCompleted for value: FolderCompleted
            /// </summary>
            [EnumMember(Value = "FolderCompleted")]
            FolderCompleted = 2

        }

        /// <summary>
        /// This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;.
        /// </summary>
        /// <value>This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;.</value>
        [DataMember(Name="eWebhookEzsignevent", EmitDefaultValue=false)]
        public EWebhookEzsigneventEnum? EWebhookEzsignevent { get; set; }
        /// <summary>
        /// This Management Event. This property will be set only if the Module is \&quot;Management\&quot;.
        /// </summary>
        /// <value>This Management Event. This property will be set only if the Module is \&quot;Management\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EWebhookManagementeventEnum
        {
            /// <summary>
            /// Enum UserCreated for value: UserCreated
            /// </summary>
            [EnumMember(Value = "UserCreated")]
            UserCreated = 1

        }

        /// <summary>
        /// This Management Event. This property will be set only if the Module is \&quot;Management\&quot;.
        /// </summary>
        /// <value>This Management Event. This property will be set only if the Module is \&quot;Management\&quot;.</value>
        [DataMember(Name="eWebhookManagementevent", EmitDefaultValue=false)]
        public EWebhookManagementeventEnum? EWebhookManagementevent { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResponse" /> class.
        /// </summary>
        /// <param name="pkiWebhookID">The Webhook ID. This value is visible in the admin interface. (required).</param>
        /// <param name="eWebhookModule">The Module generating the Event. (required).</param>
        /// <param name="eWebhookEzsignevent">This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;..</param>
        /// <param name="pksCustomerCode">The customer code assigned to your account (required).</param>
        /// <param name="sWebhookUrl">The url being called (required).</param>
        /// <param name="sWebhookEmailfailed">The email that will receive the webhook in case all attempts fail. (required).</param>
        /// <param name="eWebhookManagementevent">This Management Event. This property will be set only if the Module is \&quot;Management\&quot;..</param>
        public WebhookResponse(int pkiWebhookID = default(int), EWebhookModuleEnum eWebhookModule = default(EWebhookModuleEnum), EWebhookEzsigneventEnum? eWebhookEzsignevent = default(EWebhookEzsigneventEnum?), string pksCustomerCode = default(string), string sWebhookUrl = default(string), string sWebhookEmailfailed = default(string), EWebhookManagementeventEnum? eWebhookManagementevent = default(EWebhookManagementeventEnum?))
        {
            // to ensure "pkiWebhookID" is required (not null)
            if (pkiWebhookID == null)
            {
                throw new InvalidDataException("pkiWebhookID is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.PkiWebhookID = pkiWebhookID;
            }

            // to ensure "eWebhookModule" is required (not null)
            if (eWebhookModule == null)
            {
                throw new InvalidDataException("eWebhookModule is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.EWebhookModule = eWebhookModule;
            }

            // to ensure "pksCustomerCode" is required (not null)
            if (pksCustomerCode == null)
            {
                throw new InvalidDataException("pksCustomerCode is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.PksCustomerCode = pksCustomerCode;
            }

            // to ensure "sWebhookUrl" is required (not null)
            if (sWebhookUrl == null)
            {
                throw new InvalidDataException("sWebhookUrl is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.SWebhookUrl = sWebhookUrl;
            }

            // to ensure "sWebhookEmailfailed" is required (not null)
            if (sWebhookEmailfailed == null)
            {
                throw new InvalidDataException("sWebhookEmailfailed is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.SWebhookEmailfailed = sWebhookEmailfailed;
            }

            this.EWebhookEzsignevent = eWebhookEzsignevent;
            this.EWebhookManagementevent = eWebhookManagementevent;
        }

        /// <summary>
        /// The Webhook ID. This value is visible in the admin interface.
        /// </summary>
        /// <value>The Webhook ID. This value is visible in the admin interface.</value>
        [DataMember(Name="pkiWebhookID", EmitDefaultValue=true)]
        public int PkiWebhookID { get; set; }



        /// <summary>
        /// The customer code assigned to your account
        /// </summary>
        /// <value>The customer code assigned to your account</value>
        [DataMember(Name="pksCustomerCode", EmitDefaultValue=true)]
        public string PksCustomerCode { get; set; }

        /// <summary>
        /// The url being called
        /// </summary>
        /// <value>The url being called</value>
        [DataMember(Name="sWebhookUrl", EmitDefaultValue=true)]
        public string SWebhookUrl { get; set; }

        /// <summary>
        /// The email that will receive the webhook in case all attempts fail.
        /// </summary>
        /// <value>The email that will receive the webhook in case all attempts fail.</value>
        [DataMember(Name="sWebhookEmailfailed", EmitDefaultValue=true)]
        public string SWebhookEmailfailed { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookResponse {\n");
            sb.Append("  PkiWebhookID: ").Append(PkiWebhookID).Append("\n");
            sb.Append("  EWebhookModule: ").Append(EWebhookModule).Append("\n");
            sb.Append("  EWebhookEzsignevent: ").Append(EWebhookEzsignevent).Append("\n");
            sb.Append("  PksCustomerCode: ").Append(PksCustomerCode).Append("\n");
            sb.Append("  SWebhookUrl: ").Append(SWebhookUrl).Append("\n");
            sb.Append("  SWebhookEmailfailed: ").Append(SWebhookEmailfailed).Append("\n");
            sb.Append("  EWebhookManagementevent: ").Append(EWebhookManagementevent).Append("\n");
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
            return this.Equals(input as WebhookResponse);
        }

        /// <summary>
        /// Returns true if WebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiWebhookID == input.PkiWebhookID ||
                    (this.PkiWebhookID != null &&
                    this.PkiWebhookID.Equals(input.PkiWebhookID))
                ) && 
                (
                    this.EWebhookModule == input.EWebhookModule ||
                    (this.EWebhookModule != null &&
                    this.EWebhookModule.Equals(input.EWebhookModule))
                ) && 
                (
                    this.EWebhookEzsignevent == input.EWebhookEzsignevent ||
                    (this.EWebhookEzsignevent != null &&
                    this.EWebhookEzsignevent.Equals(input.EWebhookEzsignevent))
                ) && 
                (
                    this.PksCustomerCode == input.PksCustomerCode ||
                    (this.PksCustomerCode != null &&
                    this.PksCustomerCode.Equals(input.PksCustomerCode))
                ) && 
                (
                    this.SWebhookUrl == input.SWebhookUrl ||
                    (this.SWebhookUrl != null &&
                    this.SWebhookUrl.Equals(input.SWebhookUrl))
                ) && 
                (
                    this.SWebhookEmailfailed == input.SWebhookEmailfailed ||
                    (this.SWebhookEmailfailed != null &&
                    this.SWebhookEmailfailed.Equals(input.SWebhookEmailfailed))
                ) && 
                (
                    this.EWebhookManagementevent == input.EWebhookManagementevent ||
                    (this.EWebhookManagementevent != null &&
                    this.EWebhookManagementevent.Equals(input.EWebhookManagementevent))
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
                if (this.PkiWebhookID != null)
                    hashCode = hashCode * 59 + this.PkiWebhookID.GetHashCode();
                if (this.EWebhookModule != null)
                    hashCode = hashCode * 59 + this.EWebhookModule.GetHashCode();
                if (this.EWebhookEzsignevent != null)
                    hashCode = hashCode * 59 + this.EWebhookEzsignevent.GetHashCode();
                if (this.PksCustomerCode != null)
                    hashCode = hashCode * 59 + this.PksCustomerCode.GetHashCode();
                if (this.SWebhookUrl != null)
                    hashCode = hashCode * 59 + this.SWebhookUrl.GetHashCode();
                if (this.SWebhookEmailfailed != null)
                    hashCode = hashCode * 59 + this.SWebhookEmailfailed.GetHashCode();
                if (this.EWebhookManagementevent != null)
                    hashCode = hashCode * 59 + this.EWebhookManagementevent.GetHashCode();
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
            // PksCustomerCode (string) maxLength
            if(this.PksCustomerCode != null && this.PksCustomerCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PksCustomerCode, length must be less than 6.", new [] { "PksCustomerCode" });
            }

            // PksCustomerCode (string) minLength
            if(this.PksCustomerCode != null && this.PksCustomerCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PksCustomerCode, length must be greater than 2.", new [] { "PksCustomerCode" });
            }
 
            yield break;
        }
    }

}
