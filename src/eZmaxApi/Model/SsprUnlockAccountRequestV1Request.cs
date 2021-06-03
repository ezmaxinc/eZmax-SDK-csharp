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
    /// Request for the /1/module/sspr/unlockAccountRequest API Request
    /// </summary>
    [DataContract]
    public partial class SsprUnlockAccountRequestV1Request :  IEquatable<SsprUnlockAccountRequestV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsprUnlockAccountRequestV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SsprUnlockAccountRequestV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsprUnlockAccountRequestV1Request" /> class.
        /// </summary>
        /// <param name="pksCustomerCode">The customer code assigned to your account (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="eUserTypeSSPR">eUserTypeSSPR (required).</param>
        /// <param name="sEmailAddress">The email address..</param>
        /// <param name="sUserLoginname">The Login name of the User..</param>
        public SsprUnlockAccountRequestV1Request(string pksCustomerCode = default(string), int fkiLanguageID = default(int), FieldEUserTypeSSPR eUserTypeSSPR = default(FieldEUserTypeSSPR), string sEmailAddress = default(string), string sUserLoginname = default(string))
        {
            // to ensure "pksCustomerCode" is required (not null)
            if (pksCustomerCode == null)
            {
                throw new InvalidDataException("pksCustomerCode is a required property for SsprUnlockAccountRequestV1Request and cannot be null");
            }
            else
            {
                this.PksCustomerCode = pksCustomerCode;
            }

            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for SsprUnlockAccountRequestV1Request and cannot be null");
            }
            else
            {
                this.FkiLanguageID = fkiLanguageID;
            }

            // to ensure "eUserTypeSSPR" is required (not null)
            if (eUserTypeSSPR == null)
            {
                throw new InvalidDataException("eUserTypeSSPR is a required property for SsprUnlockAccountRequestV1Request and cannot be null");
            }
            else
            {
                this.EUserTypeSSPR = eUserTypeSSPR;
            }

            this.SEmailAddress = sEmailAddress;
            this.SUserLoginname = sUserLoginname;
        }

        /// <summary>
        /// The customer code assigned to your account
        /// </summary>
        /// <value>The customer code assigned to your account</value>
        [DataMember(Name="pksCustomerCode", EmitDefaultValue=true)]
        public string PksCustomerCode { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// Gets or Sets EUserTypeSSPR
        /// </summary>
        [DataMember(Name="eUserTypeSSPR", EmitDefaultValue=true)]
        public FieldEUserTypeSSPR EUserTypeSSPR { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name="sEmailAddress", EmitDefaultValue=false)]
        public string SEmailAddress { get; set; }

        /// <summary>
        /// The Login name of the User.
        /// </summary>
        /// <value>The Login name of the User.</value>
        [DataMember(Name="sUserLoginname", EmitDefaultValue=false)]
        public string SUserLoginname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsprUnlockAccountRequestV1Request {\n");
            sb.Append("  PksCustomerCode: ").Append(PksCustomerCode).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  EUserTypeSSPR: ").Append(EUserTypeSSPR).Append("\n");
            sb.Append("  SEmailAddress: ").Append(SEmailAddress).Append("\n");
            sb.Append("  SUserLoginname: ").Append(SUserLoginname).Append("\n");
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
            return this.Equals(input as SsprUnlockAccountRequestV1Request);
        }

        /// <summary>
        /// Returns true if SsprUnlockAccountRequestV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of SsprUnlockAccountRequestV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SsprUnlockAccountRequestV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PksCustomerCode == input.PksCustomerCode ||
                    (this.PksCustomerCode != null &&
                    this.PksCustomerCode.Equals(input.PksCustomerCode))
                ) && 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    (this.FkiLanguageID != null &&
                    this.FkiLanguageID.Equals(input.FkiLanguageID))
                ) && 
                (
                    this.EUserTypeSSPR == input.EUserTypeSSPR ||
                    (this.EUserTypeSSPR != null &&
                    this.EUserTypeSSPR.Equals(input.EUserTypeSSPR))
                ) && 
                (
                    this.SEmailAddress == input.SEmailAddress ||
                    (this.SEmailAddress != null &&
                    this.SEmailAddress.Equals(input.SEmailAddress))
                ) && 
                (
                    this.SUserLoginname == input.SUserLoginname ||
                    (this.SUserLoginname != null &&
                    this.SUserLoginname.Equals(input.SUserLoginname))
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
                if (this.PksCustomerCode != null)
                    hashCode = hashCode * 59 + this.PksCustomerCode.GetHashCode();
                if (this.FkiLanguageID != null)
                    hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.EUserTypeSSPR != null)
                    hashCode = hashCode * 59 + this.EUserTypeSSPR.GetHashCode();
                if (this.SEmailAddress != null)
                    hashCode = hashCode * 59 + this.SEmailAddress.GetHashCode();
                if (this.SUserLoginname != null)
                    hashCode = hashCode * 59 + this.SUserLoginname.GetHashCode();
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
 

 
            // FkiLanguageID (int) maximum
            if(this.FkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value less than or equal to 2.", new [] { "FkiLanguageID" });
            }

            // FkiLanguageID (int) minimum
            if(this.FkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value greater than or equal to 1.", new [] { "FkiLanguageID" });
            }

            yield break;
        }
    }

}