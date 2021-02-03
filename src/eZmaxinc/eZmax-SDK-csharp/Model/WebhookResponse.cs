/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.27
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
        public EWebhookModuleEnum eWebhookModule { get; set; }
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
        public EWebhookEzsigneventEnum? eWebhookEzsignevent { get; set; }
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
        public EWebhookManagementeventEnum? eWebhookManagementevent { get; set; }
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
        /// <param name="pksCustomerCode">The Customer Code in which the event was generated (required).</param>
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
                this.pkiWebhookID = pkiWebhookID;
            }
            
            // to ensure "eWebhookModule" is required (not null)
            if (eWebhookModule == null)
            {
                throw new InvalidDataException("eWebhookModule is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.eWebhookModule = eWebhookModule;
            }
            
            // to ensure "pksCustomerCode" is required (not null)
            if (pksCustomerCode == null)
            {
                throw new InvalidDataException("pksCustomerCode is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.pksCustomerCode = pksCustomerCode;
            }
            
            // to ensure "sWebhookUrl" is required (not null)
            if (sWebhookUrl == null)
            {
                throw new InvalidDataException("sWebhookUrl is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.sWebhookUrl = sWebhookUrl;
            }
            
            // to ensure "sWebhookEmailfailed" is required (not null)
            if (sWebhookEmailfailed == null)
            {
                throw new InvalidDataException("sWebhookEmailfailed is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.sWebhookEmailfailed = sWebhookEmailfailed;
            }
            
            this.eWebhookEzsignevent = eWebhookEzsignevent;
            this.eWebhookManagementevent = eWebhookManagementevent;
        }
        
        /// <summary>
        /// The Webhook ID. This value is visible in the admin interface.
        /// </summary>
        /// <value>The Webhook ID. This value is visible in the admin interface.</value>
        [DataMember(Name="pkiWebhookID", EmitDefaultValue=true)]
        public int pkiWebhookID { get; set; }



        /// <summary>
        /// The Customer Code in which the event was generated
        /// </summary>
        /// <value>The Customer Code in which the event was generated</value>
        [DataMember(Name="pksCustomerCode", EmitDefaultValue=true)]
        public string pksCustomerCode { get; set; }

        /// <summary>
        /// The url being called
        /// </summary>
        /// <value>The url being called</value>
        [DataMember(Name="sWebhookUrl", EmitDefaultValue=true)]
        public string sWebhookUrl { get; set; }

        /// <summary>
        /// The email that will receive the webhook in case all attempts fail.
        /// </summary>
        /// <value>The email that will receive the webhook in case all attempts fail.</value>
        [DataMember(Name="sWebhookEmailfailed", EmitDefaultValue=true)]
        public string sWebhookEmailfailed { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookResponse {\n");
            sb.Append("  pkiWebhookID: ").Append(pkiWebhookID).Append("\n");
            sb.Append("  eWebhookModule: ").Append(eWebhookModule).Append("\n");
            sb.Append("  eWebhookEzsignevent: ").Append(eWebhookEzsignevent).Append("\n");
            sb.Append("  pksCustomerCode: ").Append(pksCustomerCode).Append("\n");
            sb.Append("  sWebhookUrl: ").Append(sWebhookUrl).Append("\n");
            sb.Append("  sWebhookEmailfailed: ").Append(sWebhookEmailfailed).Append("\n");
            sb.Append("  eWebhookManagementevent: ").Append(eWebhookManagementevent).Append("\n");
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
                    this.pkiWebhookID == input.pkiWebhookID ||
                    (this.pkiWebhookID != null &&
                    this.pkiWebhookID.Equals(input.pkiWebhookID))
                ) && 
                (
                    this.eWebhookModule == input.eWebhookModule ||
                    (this.eWebhookModule != null &&
                    this.eWebhookModule.Equals(input.eWebhookModule))
                ) && 
                (
                    this.eWebhookEzsignevent == input.eWebhookEzsignevent ||
                    (this.eWebhookEzsignevent != null &&
                    this.eWebhookEzsignevent.Equals(input.eWebhookEzsignevent))
                ) && 
                (
                    this.pksCustomerCode == input.pksCustomerCode ||
                    (this.pksCustomerCode != null &&
                    this.pksCustomerCode.Equals(input.pksCustomerCode))
                ) && 
                (
                    this.sWebhookUrl == input.sWebhookUrl ||
                    (this.sWebhookUrl != null &&
                    this.sWebhookUrl.Equals(input.sWebhookUrl))
                ) && 
                (
                    this.sWebhookEmailfailed == input.sWebhookEmailfailed ||
                    (this.sWebhookEmailfailed != null &&
                    this.sWebhookEmailfailed.Equals(input.sWebhookEmailfailed))
                ) && 
                (
                    this.eWebhookManagementevent == input.eWebhookManagementevent ||
                    (this.eWebhookManagementevent != null &&
                    this.eWebhookManagementevent.Equals(input.eWebhookManagementevent))
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
                if (this.pkiWebhookID != null)
                    hashCode = hashCode * 59 + this.pkiWebhookID.GetHashCode();
                if (this.eWebhookModule != null)
                    hashCode = hashCode * 59 + this.eWebhookModule.GetHashCode();
                if (this.eWebhookEzsignevent != null)
                    hashCode = hashCode * 59 + this.eWebhookEzsignevent.GetHashCode();
                if (this.pksCustomerCode != null)
                    hashCode = hashCode * 59 + this.pksCustomerCode.GetHashCode();
                if (this.sWebhookUrl != null)
                    hashCode = hashCode * 59 + this.sWebhookUrl.GetHashCode();
                if (this.sWebhookEmailfailed != null)
                    hashCode = hashCode * 59 + this.sWebhookEmailfailed.GetHashCode();
                if (this.eWebhookManagementevent != null)
                    hashCode = hashCode * 59 + this.eWebhookManagementevent.GetHashCode();
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
