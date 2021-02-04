/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.28
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
    /// An Apikey Object
    /// </summary>
    [DataContract]
    public partial class ApikeyResponse :  IEquatable<ApikeyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyResponse" /> class.
        /// </summary>
        /// <param name="objApikeyDescription">objApikeyDescription (required).</param>
        /// <param name="sComputedToken">The secret token for the API key.  This will be returned only on creation..</param>
        /// <param name="pkiApikeyID">The unique ID of the Apikey (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public ApikeyResponse(MultilingualApikeyDescription objApikeyDescription = default(MultilingualApikeyDescription), string sComputedToken = default(string), int pkiApikeyID = default(int), CommonAudit objAudit = default(CommonAudit))
        {
            // to ensure "objApikeyDescription" is required (not null)
            if (objApikeyDescription == null)
            {
                throw new InvalidDataException("objApikeyDescription is a required property for ApikeyResponse and cannot be null");
            }
            else
            {
                this.objApikeyDescription = objApikeyDescription;
            }
            
            // to ensure "pkiApikeyID" is required (not null)
            if (pkiApikeyID == null)
            {
                throw new InvalidDataException("pkiApikeyID is a required property for ApikeyResponse and cannot be null");
            }
            else
            {
                this.pkiApikeyID = pkiApikeyID;
            }
            
            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new InvalidDataException("objAudit is a required property for ApikeyResponse and cannot be null");
            }
            else
            {
                this.objAudit = objAudit;
            }
            
            this.sComputedToken = sComputedToken;
        }
        
        /// <summary>
        /// Gets or Sets objApikeyDescription
        /// </summary>
        [DataMember(Name="objApikeyDescription", EmitDefaultValue=true)]
        public MultilingualApikeyDescription objApikeyDescription { get; set; }

        /// <summary>
        /// The secret token for the API key.  This will be returned only on creation.
        /// </summary>
        /// <value>The secret token for the API key.  This will be returned only on creation.</value>
        [DataMember(Name="sComputedToken", EmitDefaultValue=false)]
        public string sComputedToken { get; set; }

        /// <summary>
        /// The unique ID of the Apikey
        /// </summary>
        /// <value>The unique ID of the Apikey</value>
        [DataMember(Name="pkiApikeyID", EmitDefaultValue=true)]
        public int pkiApikeyID { get; set; }

        /// <summary>
        /// Gets or Sets objAudit
        /// </summary>
        [DataMember(Name="objAudit", EmitDefaultValue=true)]
        public CommonAudit objAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApikeyResponse {\n");
            sb.Append("  objApikeyDescription: ").Append(objApikeyDescription).Append("\n");
            sb.Append("  sComputedToken: ").Append(sComputedToken).Append("\n");
            sb.Append("  pkiApikeyID: ").Append(pkiApikeyID).Append("\n");
            sb.Append("  objAudit: ").Append(objAudit).Append("\n");
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
            return this.Equals(input as ApikeyResponse);
        }

        /// <summary>
        /// Returns true if ApikeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objApikeyDescription == input.objApikeyDescription ||
                    (this.objApikeyDescription != null &&
                    this.objApikeyDescription.Equals(input.objApikeyDescription))
                ) && 
                (
                    this.sComputedToken == input.sComputedToken ||
                    (this.sComputedToken != null &&
                    this.sComputedToken.Equals(input.sComputedToken))
                ) && 
                (
                    this.pkiApikeyID == input.pkiApikeyID ||
                    (this.pkiApikeyID != null &&
                    this.pkiApikeyID.Equals(input.pkiApikeyID))
                ) && 
                (
                    this.objAudit == input.objAudit ||
                    (this.objAudit != null &&
                    this.objAudit.Equals(input.objAudit))
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
                if (this.objApikeyDescription != null)
                    hashCode = hashCode * 59 + this.objApikeyDescription.GetHashCode();
                if (this.sComputedToken != null)
                    hashCode = hashCode * 59 + this.sComputedToken.GetHashCode();
                if (this.pkiApikeyID != null)
                    hashCode = hashCode * 59 + this.pkiApikeyID.GetHashCode();
                if (this.objAudit != null)
                    hashCode = hashCode * 59 + this.objAudit.GetHashCode();
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
