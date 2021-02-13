/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.
 *
 * The version of the OpenAPI document: 1.0.30
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
    /// A Contactinformations Object
    /// </summary>
    [DataContract]
    public partial class ContactinformationsRequest :  IEquatable<ContactinformationsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactinformationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequest" /> class.
        /// </summary>
        /// <param name="iAddressDefault">The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iPhoneDefault">The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iEmailDefault">The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iWebsiteDefault">The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        public ContactinformationsRequest(int iAddressDefault = default(int), int iPhoneDefault = default(int), int iEmailDefault = default(int), int iWebsiteDefault = default(int))
        {
            // to ensure "iAddressDefault" is required (not null)
            if (iAddressDefault == null)
            {
                throw new InvalidDataException("iAddressDefault is a required property for ContactinformationsRequest and cannot be null");
            }
            else
            {
                this.iAddressDefault = iAddressDefault;
            }
            
            // to ensure "iPhoneDefault" is required (not null)
            if (iPhoneDefault == null)
            {
                throw new InvalidDataException("iPhoneDefault is a required property for ContactinformationsRequest and cannot be null");
            }
            else
            {
                this.iPhoneDefault = iPhoneDefault;
            }
            
            // to ensure "iEmailDefault" is required (not null)
            if (iEmailDefault == null)
            {
                throw new InvalidDataException("iEmailDefault is a required property for ContactinformationsRequest and cannot be null");
            }
            else
            {
                this.iEmailDefault = iEmailDefault;
            }
            
            // to ensure "iWebsiteDefault" is required (not null)
            if (iWebsiteDefault == null)
            {
                throw new InvalidDataException("iWebsiteDefault is a required property for ContactinformationsRequest and cannot be null");
            }
            else
            {
                this.iWebsiteDefault = iWebsiteDefault;
            }
            
        }
        
        /// <summary>
        /// The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name="iAddressDefault", EmitDefaultValue=true)]
        public int iAddressDefault { get; set; }

        /// <summary>
        /// The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name="iPhoneDefault", EmitDefaultValue=true)]
        public int iPhoneDefault { get; set; }

        /// <summary>
        /// The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name="iEmailDefault", EmitDefaultValue=true)]
        public int iEmailDefault { get; set; }

        /// <summary>
        /// The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name="iWebsiteDefault", EmitDefaultValue=true)]
        public int iWebsiteDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactinformationsRequest {\n");
            sb.Append("  iAddressDefault: ").Append(iAddressDefault).Append("\n");
            sb.Append("  iPhoneDefault: ").Append(iPhoneDefault).Append("\n");
            sb.Append("  iEmailDefault: ").Append(iEmailDefault).Append("\n");
            sb.Append("  iWebsiteDefault: ").Append(iWebsiteDefault).Append("\n");
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
            return this.Equals(input as ContactinformationsRequest);
        }

        /// <summary>
        /// Returns true if ContactinformationsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactinformationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactinformationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.iAddressDefault == input.iAddressDefault ||
                    (this.iAddressDefault != null &&
                    this.iAddressDefault.Equals(input.iAddressDefault))
                ) && 
                (
                    this.iPhoneDefault == input.iPhoneDefault ||
                    (this.iPhoneDefault != null &&
                    this.iPhoneDefault.Equals(input.iPhoneDefault))
                ) && 
                (
                    this.iEmailDefault == input.iEmailDefault ||
                    (this.iEmailDefault != null &&
                    this.iEmailDefault.Equals(input.iEmailDefault))
                ) && 
                (
                    this.iWebsiteDefault == input.iWebsiteDefault ||
                    (this.iWebsiteDefault != null &&
                    this.iWebsiteDefault.Equals(input.iWebsiteDefault))
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
                if (this.iAddressDefault != null)
                    hashCode = hashCode * 59 + this.iAddressDefault.GetHashCode();
                if (this.iPhoneDefault != null)
                    hashCode = hashCode * 59 + this.iPhoneDefault.GetHashCode();
                if (this.iEmailDefault != null)
                    hashCode = hashCode * 59 + this.iEmailDefault.GetHashCode();
                if (this.iWebsiteDefault != null)
                    hashCode = hashCode * 59 + this.iWebsiteDefault.GetHashCode();
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
