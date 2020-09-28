/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.14
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
    /// A Phone Object
    /// </summary>
    [DataContract]
    public partial class PhoneRequest :  IEquatable<PhoneRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneRequest" /> class.
        /// </summary>
        /// <param name="fkiPhonetypeID">The unique ID of the Phonetype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Mobile| |4|Fax| |5|Pager| |6|Toll Free| (required).</param>
        /// <param name="ePhoneType">ePhoneType (required).</param>
        /// <param name="sPhoneRegion">The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123.</param>
        /// <param name="sPhoneExchange">The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123.</param>
        /// <param name="sPhoneNumber">The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123.</param>
        /// <param name="sPhoneInternational">The international phone number. (For phone numbers outside of North)  Do not specify the \&quot;011\&quot; part of the phone number used to dial an international phone number from North America.  For example for this sample phone number \&quot;+442071838750\&quot;, you would send \&quot;442071838750\&quot; without the \&quot;+\&quot; sign..</param>
        /// <param name="sPhoneExtension">The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers.</param>
        public PhoneRequest(int fkiPhonetypeID = default(int), FieldEPhoneType ePhoneType = default(FieldEPhoneType), string sPhoneRegion = default(string), string sPhoneExchange = default(string), string sPhoneNumber = default(string), string sPhoneInternational = default(string), string sPhoneExtension = default(string))
        {
            // to ensure "fkiPhonetypeID" is required (not null)
            if (fkiPhonetypeID == null)
            {
                throw new InvalidDataException("fkiPhonetypeID is a required property for PhoneRequest and cannot be null");
            }
            else
            {
                this.fkiPhonetypeID = fkiPhonetypeID;
            }
            
            // to ensure "ePhoneType" is required (not null)
            if (ePhoneType == null)
            {
                throw new InvalidDataException("ePhoneType is a required property for PhoneRequest and cannot be null");
            }
            else
            {
                this.ePhoneType = ePhoneType;
            }
            
            this.sPhoneRegion = sPhoneRegion;
            this.sPhoneExchange = sPhoneExchange;
            this.sPhoneNumber = sPhoneNumber;
            this.sPhoneInternational = sPhoneInternational;
            this.sPhoneExtension = sPhoneExtension;
        }
        
        /// <summary>
        /// The unique ID of the Phonetype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Mobile| |4|Fax| |5|Pager| |6|Toll Free|
        /// </summary>
        /// <value>The unique ID of the Phonetype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Mobile| |4|Fax| |5|Pager| |6|Toll Free|</value>
        [DataMember(Name="fkiPhonetypeID", EmitDefaultValue=true)]
        public int fkiPhonetypeID { get; set; }

        /// <summary>
        /// Gets or Sets ePhoneType
        /// </summary>
        [DataMember(Name="ePhoneType", EmitDefaultValue=true)]
        public FieldEPhoneType ePhoneType { get; set; }

        /// <summary>
        /// The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name="sPhoneRegion", EmitDefaultValue=false)]
        public string sPhoneRegion { get; set; }

        /// <summary>
        /// The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name="sPhoneExchange", EmitDefaultValue=false)]
        public string sPhoneExchange { get; set; }

        /// <summary>
        /// The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name="sPhoneNumber", EmitDefaultValue=false)]
        public string sPhoneNumber { get; set; }

        /// <summary>
        /// The international phone number. (For phone numbers outside of North)  Do not specify the \&quot;011\&quot; part of the phone number used to dial an international phone number from North America.  For example for this sample phone number \&quot;+442071838750\&quot;, you would send \&quot;442071838750\&quot; without the \&quot;+\&quot; sign.
        /// </summary>
        /// <value>The international phone number. (For phone numbers outside of North)  Do not specify the \&quot;011\&quot; part of the phone number used to dial an international phone number from North America.  For example for this sample phone number \&quot;+442071838750\&quot;, you would send \&quot;442071838750\&quot; without the \&quot;+\&quot; sign.</value>
        [DataMember(Name="sPhoneInternational", EmitDefaultValue=false)]
        public string sPhoneInternational { get; set; }

        /// <summary>
        /// The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers
        /// </summary>
        /// <value>The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers</value>
        [DataMember(Name="sPhoneExtension", EmitDefaultValue=false)]
        public string sPhoneExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneRequest {\n");
            sb.Append("  fkiPhonetypeID: ").Append(fkiPhonetypeID).Append("\n");
            sb.Append("  ePhoneType: ").Append(ePhoneType).Append("\n");
            sb.Append("  sPhoneRegion: ").Append(sPhoneRegion).Append("\n");
            sb.Append("  sPhoneExchange: ").Append(sPhoneExchange).Append("\n");
            sb.Append("  sPhoneNumber: ").Append(sPhoneNumber).Append("\n");
            sb.Append("  sPhoneInternational: ").Append(sPhoneInternational).Append("\n");
            sb.Append("  sPhoneExtension: ").Append(sPhoneExtension).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as PhoneRequest);
        }

        /// <summary>
        /// Returns true if PhoneRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiPhonetypeID == input.fkiPhonetypeID ||
                    (this.fkiPhonetypeID != null &&
                    this.fkiPhonetypeID.Equals(input.fkiPhonetypeID))
                ) && 
                (
                    this.ePhoneType == input.ePhoneType ||
                    (this.ePhoneType != null &&
                    this.ePhoneType.Equals(input.ePhoneType))
                ) && 
                (
                    this.sPhoneRegion == input.sPhoneRegion ||
                    (this.sPhoneRegion != null &&
                    this.sPhoneRegion.Equals(input.sPhoneRegion))
                ) && 
                (
                    this.sPhoneExchange == input.sPhoneExchange ||
                    (this.sPhoneExchange != null &&
                    this.sPhoneExchange.Equals(input.sPhoneExchange))
                ) && 
                (
                    this.sPhoneNumber == input.sPhoneNumber ||
                    (this.sPhoneNumber != null &&
                    this.sPhoneNumber.Equals(input.sPhoneNumber))
                ) && 
                (
                    this.sPhoneInternational == input.sPhoneInternational ||
                    (this.sPhoneInternational != null &&
                    this.sPhoneInternational.Equals(input.sPhoneInternational))
                ) && 
                (
                    this.sPhoneExtension == input.sPhoneExtension ||
                    (this.sPhoneExtension != null &&
                    this.sPhoneExtension.Equals(input.sPhoneExtension))
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
                if (this.fkiPhonetypeID != null)
                    hashCode = hashCode * 59 + this.fkiPhonetypeID.GetHashCode();
                if (this.ePhoneType != null)
                    hashCode = hashCode * 59 + this.ePhoneType.GetHashCode();
                if (this.sPhoneRegion != null)
                    hashCode = hashCode * 59 + this.sPhoneRegion.GetHashCode();
                if (this.sPhoneExchange != null)
                    hashCode = hashCode * 59 + this.sPhoneExchange.GetHashCode();
                if (this.sPhoneNumber != null)
                    hashCode = hashCode * 59 + this.sPhoneNumber.GetHashCode();
                if (this.sPhoneInternational != null)
                    hashCode = hashCode * 59 + this.sPhoneInternational.GetHashCode();
                if (this.sPhoneExtension != null)
                    hashCode = hashCode * 59 + this.sPhoneExtension.GetHashCode();
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
