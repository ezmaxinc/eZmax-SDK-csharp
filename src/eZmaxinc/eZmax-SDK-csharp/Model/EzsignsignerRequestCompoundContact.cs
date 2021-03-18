/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.37
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
    /// A Ezsignsigner-&gt;Contact Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class EzsignsignerRequestCompoundContact :  IEquatable<EzsignsignerRequestCompoundContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignerRequestCompoundContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignerRequestCompoundContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignerRequestCompoundContact" /> class.
        /// </summary>
        /// <param name="sContactFirstname">The first name of the Contact (required).</param>
        /// <param name="sContactLastname">The last name of the Contact (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEmailAddress">The email address of the contact. Must be filled if email authentification was requested.</param>
        /// <param name="sPhoneNumber">The Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany..</param>
        /// <param name="sPhoneNumberCell">The Cell Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany..</param>
        public EzsignsignerRequestCompoundContact(string sContactFirstname = default(string), string sContactLastname = default(string), int fkiLanguageID = default(int), string sEmailAddress = default(string), string sPhoneNumber = default(string), string sPhoneNumberCell = default(string))
        {
            // to ensure "sContactFirstname" is required (not null)
            if (sContactFirstname == null)
            {
                throw new InvalidDataException("sContactFirstname is a required property for EzsignsignerRequestCompoundContact and cannot be null");
            }
            else
            {
                this.sContactFirstname = sContactFirstname;
            }

            // to ensure "sContactLastname" is required (not null)
            if (sContactLastname == null)
            {
                throw new InvalidDataException("sContactLastname is a required property for EzsignsignerRequestCompoundContact and cannot be null");
            }
            else
            {
                this.sContactLastname = sContactLastname;
            }

            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for EzsignsignerRequestCompoundContact and cannot be null");
            }
            else
            {
                this.fkiLanguageID = fkiLanguageID;
            }

            this.sEmailAddress = sEmailAddress;
            this.sPhoneNumber = sPhoneNumber;
            this.sPhoneNumberCell = sPhoneNumberCell;
        }

        /// <summary>
        /// The first name of the Contact
        /// </summary>
        /// <value>The first name of the Contact</value>
        [DataMember(Name="sContactFirstname", EmitDefaultValue=true)]
        public string sContactFirstname { get; set; }

        /// <summary>
        /// The last name of the Contact
        /// </summary>
        /// <value>The last name of the Contact</value>
        [DataMember(Name="sContactLastname", EmitDefaultValue=true)]
        public string sContactLastname { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// The email address of the contact. Must be filled if email authentification was requested
        /// </summary>
        /// <value>The email address of the contact. Must be filled if email authentification was requested</value>
        [DataMember(Name="sEmailAddress", EmitDefaultValue=false)]
        public string sEmailAddress { get; set; }

        /// <summary>
        /// The Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany.
        /// </summary>
        /// <value>The Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany.</value>
        [DataMember(Name="sPhoneNumber", EmitDefaultValue=false)]
        public string sPhoneNumber { get; set; }

        /// <summary>
        /// The Cell Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany.
        /// </summary>
        /// <value>The Cell Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany.</value>
        [DataMember(Name="sPhoneNumberCell", EmitDefaultValue=false)]
        public string sPhoneNumberCell { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignerRequestCompoundContact {\n");
            sb.Append("  sContactFirstname: ").Append(sContactFirstname).Append("\n");
            sb.Append("  sContactLastname: ").Append(sContactLastname).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sEmailAddress: ").Append(sEmailAddress).Append("\n");
            sb.Append("  sPhoneNumber: ").Append(sPhoneNumber).Append("\n");
            sb.Append("  sPhoneNumberCell: ").Append(sPhoneNumberCell).Append("\n");
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
            return this.Equals(input as EzsignsignerRequestCompoundContact);
        }

        /// <summary>
        /// Returns true if EzsignsignerRequestCompoundContact instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignerRequestCompoundContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignerRequestCompoundContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sContactFirstname == input.sContactFirstname ||
                    (this.sContactFirstname != null &&
                    this.sContactFirstname.Equals(input.sContactFirstname))
                ) && 
                (
                    this.sContactLastname == input.sContactLastname ||
                    (this.sContactLastname != null &&
                    this.sContactLastname.Equals(input.sContactLastname))
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    (this.fkiLanguageID != null &&
                    this.fkiLanguageID.Equals(input.fkiLanguageID))
                ) && 
                (
                    this.sEmailAddress == input.sEmailAddress ||
                    (this.sEmailAddress != null &&
                    this.sEmailAddress.Equals(input.sEmailAddress))
                ) && 
                (
                    this.sPhoneNumber == input.sPhoneNumber ||
                    (this.sPhoneNumber != null &&
                    this.sPhoneNumber.Equals(input.sPhoneNumber))
                ) && 
                (
                    this.sPhoneNumberCell == input.sPhoneNumberCell ||
                    (this.sPhoneNumberCell != null &&
                    this.sPhoneNumberCell.Equals(input.sPhoneNumberCell))
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
                if (this.sContactFirstname != null)
                    hashCode = hashCode * 59 + this.sContactFirstname.GetHashCode();
                if (this.sContactLastname != null)
                    hashCode = hashCode * 59 + this.sContactLastname.GetHashCode();
                if (this.fkiLanguageID != null)
                    hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sEmailAddress != null)
                    hashCode = hashCode * 59 + this.sEmailAddress.GetHashCode();
                if (this.sPhoneNumber != null)
                    hashCode = hashCode * 59 + this.sPhoneNumber.GetHashCode();
                if (this.sPhoneNumberCell != null)
                    hashCode = hashCode * 59 + this.sPhoneNumberCell.GetHashCode();
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

 
            // fkiLanguageID (int) maximum
            if(this.fkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value less than or equal to 2.", new [] { "fkiLanguageID" });
            }

            // fkiLanguageID (int) minimum
            if(this.fkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value greater than or equal to 1.", new [] { "fkiLanguageID" });
            }

            yield break;
        }
    }

}
