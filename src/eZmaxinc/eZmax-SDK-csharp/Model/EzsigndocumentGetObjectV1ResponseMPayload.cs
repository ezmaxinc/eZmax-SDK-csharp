/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.11
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
    /// Payload for the /1/object/ezsigndocument/getObject API Request
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentGetObjectV1ResponseMPayload : EzsigndocumentResponse,  IEquatable<EzsigndocumentGetObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetObjectV1ResponseMPayload" /> class.
        /// </summary>
        public EzsigndocumentGetObjectV1ResponseMPayload(int fkiEzsignfolderID = default(int), string dtEzsigndocumentDuedate = default(string), int fkiLanguageID = default(int), string sEzsigndocumentFilename = default(string), string sEzsigndocumentName = default(string), int pkiEzsigndocumentID = default(int), FieldEEzsigndocumentStep eEzsigndocumentStep = default(FieldEEzsigndocumentStep), string dtEzsigndocumentFirstsend = default(string), string dtEzsigndocumentLastsend = default(string), int iEzsigndocumentOrder = default(int), int iEzsigndocumentPagetotal = default(int), int iEzsigndocumentSignaturesigned = default(int), int iEzsigndocumentSignaturetotal = default(int), string sEzsigndocumentMD5initial = default(string), string sEzsigndocumentMD5signed = default(string), int fkiUserIDCreated = default(int), int fkiUserIDModified = default(int), int fkiApikeyIDCreated = default(int), int fkiApikeyIDModified = default(int), string dtCreatedDate = default(string), string dtModifiedDate = default(string)) : base()
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetObjectV1ResponseMPayload {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsigndocumentGetObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigndocumentGetObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentGetObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentGetObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
