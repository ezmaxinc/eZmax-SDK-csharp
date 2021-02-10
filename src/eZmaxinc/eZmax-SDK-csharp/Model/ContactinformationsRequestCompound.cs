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
    /// A Contactinformations Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class ContactinformationsRequestCompound :  IEquatable<ContactinformationsRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactinformationsRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequestCompound" /> class.
        /// </summary>
        /// <param name="aObjAddress">aObjAddress (required).</param>
        /// <param name="aObjPhone">aObjPhone (required).</param>
        /// <param name="aObjEmail">aObjEmail (required).</param>
        /// <param name="aObjWebsite">aObjWebsite (required).</param>
        /// <param name="iAddressDefault">The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iPhoneDefault">The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iEmailDefault">The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iWebsiteDefault">The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        public ContactinformationsRequestCompound(List<AddressRequest> aObjAddress = default(List<AddressRequest>), List<PhoneRequest> aObjPhone = default(List<PhoneRequest>), List<EmailRequest> aObjEmail = default(List<EmailRequest>), List<WebsiteRequest> aObjWebsite = default(List<WebsiteRequest>), int iAddressDefault = default(int), int iPhoneDefault = default(int), int iEmailDefault = default(int), int iWebsiteDefault = default(int))
        {
            // to ensure "aObjAddress" is required (not null)
            if (aObjAddress == null)
            {
                throw new InvalidDataException("aObjAddress is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.a_objAddress = aObjAddress;
            }
            
            // to ensure "aObjPhone" is required (not null)
            if (aObjPhone == null)
            {
                throw new InvalidDataException("aObjPhone is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.a_objPhone = aObjPhone;
            }
            
            // to ensure "aObjEmail" is required (not null)
            if (aObjEmail == null)
            {
                throw new InvalidDataException("aObjEmail is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.a_objEmail = aObjEmail;
            }
            
            // to ensure "aObjWebsite" is required (not null)
            if (aObjWebsite == null)
            {
                throw new InvalidDataException("aObjWebsite is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.a_objWebsite = aObjWebsite;
            }
            
            // to ensure "iAddressDefault" is required (not null)
            if (iAddressDefault == null)
            {
                throw new InvalidDataException("iAddressDefault is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.iAddressDefault = iAddressDefault;
            }
            
            // to ensure "iPhoneDefault" is required (not null)
            if (iPhoneDefault == null)
            {
                throw new InvalidDataException("iPhoneDefault is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.iPhoneDefault = iPhoneDefault;
            }
            
            // to ensure "iEmailDefault" is required (not null)
            if (iEmailDefault == null)
            {
                throw new InvalidDataException("iEmailDefault is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.iEmailDefault = iEmailDefault;
            }
            
            // to ensure "iWebsiteDefault" is required (not null)
            if (iWebsiteDefault == null)
            {
                throw new InvalidDataException("iWebsiteDefault is a required property for ContactinformationsRequestCompound and cannot be null");
            }
            else
            {
                this.iWebsiteDefault = iWebsiteDefault;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets a_objAddress
        /// </summary>
        [DataMember(Name="a_objAddress", EmitDefaultValue=true)]
        public List<AddressRequest> a_objAddress { get; set; }

        /// <summary>
        /// Gets or Sets a_objPhone
        /// </summary>
        [DataMember(Name="a_objPhone", EmitDefaultValue=true)]
        public List<PhoneRequest> a_objPhone { get; set; }

        /// <summary>
        /// Gets or Sets a_objEmail
        /// </summary>
        [DataMember(Name="a_objEmail", EmitDefaultValue=true)]
        public List<EmailRequest> a_objEmail { get; set; }

        /// <summary>
        /// Gets or Sets a_objWebsite
        /// </summary>
        [DataMember(Name="a_objWebsite", EmitDefaultValue=true)]
        public List<WebsiteRequest> a_objWebsite { get; set; }

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
            sb.Append("class ContactinformationsRequestCompound {\n");
            sb.Append("  a_objAddress: ").Append(a_objAddress).Append("\n");
            sb.Append("  a_objPhone: ").Append(a_objPhone).Append("\n");
            sb.Append("  a_objEmail: ").Append(a_objEmail).Append("\n");
            sb.Append("  a_objWebsite: ").Append(a_objWebsite).Append("\n");
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
            return this.Equals(input as ContactinformationsRequestCompound);
        }

        /// <summary>
        /// Returns true if ContactinformationsRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactinformationsRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactinformationsRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_objAddress == input.a_objAddress ||
                    this.a_objAddress != null &&
                    input.a_objAddress != null &&
                    this.a_objAddress.SequenceEqual(input.a_objAddress)
                ) && 
                (
                    this.a_objPhone == input.a_objPhone ||
                    this.a_objPhone != null &&
                    input.a_objPhone != null &&
                    this.a_objPhone.SequenceEqual(input.a_objPhone)
                ) && 
                (
                    this.a_objEmail == input.a_objEmail ||
                    this.a_objEmail != null &&
                    input.a_objEmail != null &&
                    this.a_objEmail.SequenceEqual(input.a_objEmail)
                ) && 
                (
                    this.a_objWebsite == input.a_objWebsite ||
                    this.a_objWebsite != null &&
                    input.a_objWebsite != null &&
                    this.a_objWebsite.SequenceEqual(input.a_objWebsite)
                ) && 
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
                if (this.a_objAddress != null)
                    hashCode = hashCode * 59 + this.a_objAddress.GetHashCode();
                if (this.a_objPhone != null)
                    hashCode = hashCode * 59 + this.a_objPhone.GetHashCode();
                if (this.a_objEmail != null)
                    hashCode = hashCode * 59 + this.a_objEmail.GetHashCode();
                if (this.a_objWebsite != null)
                    hashCode = hashCode * 59 + this.a_objWebsite.GetHashCode();
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
