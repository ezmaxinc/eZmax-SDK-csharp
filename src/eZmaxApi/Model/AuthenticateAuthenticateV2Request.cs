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
    /// Request for the /2/module/authenticate/authenticate API Request
    /// </summary>
    [DataContract]
    public partial class AuthenticateAuthenticateV2Request :  IEquatable<AuthenticateAuthenticateV2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateAuthenticateV2Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticateAuthenticateV2Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateAuthenticateV2Request" /> class.
        /// </summary>
        /// <param name="pksCustomerCode">The customer code assigned to your account (required).</param>
        /// <param name="sEmailAddress">The email address..</param>
        /// <param name="sUserLoginname">The Login name of the User..</param>
        /// <param name="sPassword">A Password.  Must meet complexity requirements.</param>
        /// <param name="sPasswordEncrypted">A Password encrypted and encoded in Base64  Must meet complexity requirements.</param>
        public AuthenticateAuthenticateV2Request(string pksCustomerCode = default(string), string sEmailAddress = default(string), string sUserLoginname = default(string), string sPassword = default(string), string sPasswordEncrypted = default(string))
        {
            // to ensure "pksCustomerCode" is required (not null)
            if (pksCustomerCode == null)
            {
                throw new InvalidDataException("pksCustomerCode is a required property for AuthenticateAuthenticateV2Request and cannot be null");
            }
            else
            {
                this.PksCustomerCode = pksCustomerCode;
            }

            this.SEmailAddress = sEmailAddress;
            this.SUserLoginname = sUserLoginname;
            this.SPassword = sPassword;
            this.SPasswordEncrypted = sPasswordEncrypted;
        }

        /// <summary>
        /// The customer code assigned to your account
        /// </summary>
        /// <value>The customer code assigned to your account</value>
        [DataMember(Name="pksCustomerCode", EmitDefaultValue=true)]
        public string PksCustomerCode { get; set; }

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
        /// A Password.  Must meet complexity requirements
        /// </summary>
        /// <value>A Password.  Must meet complexity requirements</value>
        [DataMember(Name="sPassword", EmitDefaultValue=false)]
        public string SPassword { get; set; }

        /// <summary>
        /// A Password encrypted and encoded in Base64  Must meet complexity requirements
        /// </summary>
        /// <value>A Password encrypted and encoded in Base64  Must meet complexity requirements</value>
        [DataMember(Name="sPasswordEncrypted", EmitDefaultValue=false)]
        public string SPasswordEncrypted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticateAuthenticateV2Request {\n");
            sb.Append("  PksCustomerCode: ").Append(PksCustomerCode).Append("\n");
            sb.Append("  SEmailAddress: ").Append(SEmailAddress).Append("\n");
            sb.Append("  SUserLoginname: ").Append(SUserLoginname).Append("\n");
            sb.Append("  SPassword: ").Append(SPassword).Append("\n");
            sb.Append("  SPasswordEncrypted: ").Append(SPasswordEncrypted).Append("\n");
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
            return this.Equals(input as AuthenticateAuthenticateV2Request);
        }

        /// <summary>
        /// Returns true if AuthenticateAuthenticateV2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticateAuthenticateV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticateAuthenticateV2Request input)
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
                    this.SEmailAddress == input.SEmailAddress ||
                    (this.SEmailAddress != null &&
                    this.SEmailAddress.Equals(input.SEmailAddress))
                ) && 
                (
                    this.SUserLoginname == input.SUserLoginname ||
                    (this.SUserLoginname != null &&
                    this.SUserLoginname.Equals(input.SUserLoginname))
                ) && 
                (
                    this.SPassword == input.SPassword ||
                    (this.SPassword != null &&
                    this.SPassword.Equals(input.SPassword))
                ) && 
                (
                    this.SPasswordEncrypted == input.SPasswordEncrypted ||
                    (this.SPasswordEncrypted != null &&
                    this.SPasswordEncrypted.Equals(input.SPasswordEncrypted))
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
                if (this.SEmailAddress != null)
                    hashCode = hashCode * 59 + this.SEmailAddress.GetHashCode();
                if (this.SUserLoginname != null)
                    hashCode = hashCode * 59 + this.SUserLoginname.GetHashCode();
                if (this.SPassword != null)
                    hashCode = hashCode * 59 + this.SPassword.GetHashCode();
                if (this.SPasswordEncrypted != null)
                    hashCode = hashCode * 59 + this.SPasswordEncrypted.GetHashCode();
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
