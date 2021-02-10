/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.29
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
    /// This is a debug object containing debugging information on the actual function
    /// </summary>
    [DataContract]
    public partial class CommonResponseObjDebugPayload :  IEquatable<CommonResponseObjDebugPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjDebugPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseObjDebugPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjDebugPayload" /> class.
        /// </summary>
        /// <param name="iVersionMin">The minimum version of the function that can be called (required).</param>
        /// <param name="iVersionMax">The maximum version of the function that can be called (required).</param>
        /// <param name="aRequiredPermissions">An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them. (required).</param>
        public CommonResponseObjDebugPayload(int iVersionMin = default(int), int iVersionMax = default(int), List<int> aRequiredPermissions = default(List<int>))
        {
            // to ensure "iVersionMin" is required (not null)
            if (iVersionMin == null)
            {
                throw new InvalidDataException("iVersionMin is a required property for CommonResponseObjDebugPayload and cannot be null");
            }
            else
            {
                this.iVersionMin = iVersionMin;
            }
            
            // to ensure "iVersionMax" is required (not null)
            if (iVersionMax == null)
            {
                throw new InvalidDataException("iVersionMax is a required property for CommonResponseObjDebugPayload and cannot be null");
            }
            else
            {
                this.iVersionMax = iVersionMax;
            }
            
            // to ensure "aRequiredPermissions" is required (not null)
            if (aRequiredPermissions == null)
            {
                throw new InvalidDataException("aRequiredPermissions is a required property for CommonResponseObjDebugPayload and cannot be null");
            }
            else
            {
                this.a_RequiredPermissions = aRequiredPermissions;
            }
            
        }
        
        /// <summary>
        /// The minimum version of the function that can be called
        /// </summary>
        /// <value>The minimum version of the function that can be called</value>
        [DataMember(Name="iVersionMin", EmitDefaultValue=true)]
        public int iVersionMin { get; set; }

        /// <summary>
        /// The maximum version of the function that can be called
        /// </summary>
        /// <value>The maximum version of the function that can be called</value>
        [DataMember(Name="iVersionMax", EmitDefaultValue=true)]
        public int iVersionMax { get; set; }

        /// <summary>
        /// An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them.
        /// </summary>
        /// <value>An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them.</value>
        [DataMember(Name="a_RequiredPermissions", EmitDefaultValue=true)]
        public List<int> a_RequiredPermissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseObjDebugPayload {\n");
            sb.Append("  iVersionMin: ").Append(iVersionMin).Append("\n");
            sb.Append("  iVersionMax: ").Append(iVersionMax).Append("\n");
            sb.Append("  a_RequiredPermissions: ").Append(a_RequiredPermissions).Append("\n");
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
            return this.Equals(input as CommonResponseObjDebugPayload);
        }

        /// <summary>
        /// Returns true if CommonResponseObjDebugPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseObjDebugPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseObjDebugPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.iVersionMin == input.iVersionMin ||
                    (this.iVersionMin != null &&
                    this.iVersionMin.Equals(input.iVersionMin))
                ) && 
                (
                    this.iVersionMax == input.iVersionMax ||
                    (this.iVersionMax != null &&
                    this.iVersionMax.Equals(input.iVersionMax))
                ) && 
                (
                    this.a_RequiredPermissions == input.a_RequiredPermissions ||
                    this.a_RequiredPermissions != null &&
                    input.a_RequiredPermissions != null &&
                    this.a_RequiredPermissions.SequenceEqual(input.a_RequiredPermissions)
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
                if (this.iVersionMin != null)
                    hashCode = hashCode * 59 + this.iVersionMin.GetHashCode();
                if (this.iVersionMax != null)
                    hashCode = hashCode * 59 + this.iVersionMax.GetHashCode();
                if (this.a_RequiredPermissions != null)
                    hashCode = hashCode * 59 + this.a_RequiredPermissions.GetHashCode();
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
