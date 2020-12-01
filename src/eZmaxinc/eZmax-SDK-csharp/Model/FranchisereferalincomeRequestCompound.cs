/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.19
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
    /// A Franchisereferalincome Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class FranchisereferalincomeRequestCompound :  IEquatable<FranchisereferalincomeRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchisereferalincomeRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequestCompound" /> class.
        /// </summary>
        /// <param name="objAddress">objAddress.</param>
        /// <param name="aObjContact">aObjContact (required).</param>
        /// <param name="fkiFranchisebrokerID">The unique ID of the Franchisebroker (required).</param>
        /// <param name="fkiFranchisereferalincomeprogramID">The unique ID of the Franchisereferalincomeprogram (required).</param>
        /// <param name="fkiPeriodID">The unique ID of the Period (required).</param>
        /// <param name="dFranchisereferalincomeLoan">The loan amount (required).</param>
        /// <param name="dFranchisereferalincomeFranchiseamount">The amount that will be given to the franchise (required).</param>
        /// <param name="dFranchisereferalincomeFranchisoramount">The amount that will be kept by the franchisor (required).</param>
        /// <param name="dFranchisereferalincomeAgentamount">The amount that will be given to the agent (required).</param>
        /// <param name="dtFranchisereferalincomeDisbursed">The date the amounts were disbursed (required).</param>
        /// <param name="tFranchisereferalincomeComment">A comment about the transaction (required).</param>
        /// <param name="fkiFranchiseofficeID">The unique ID of the Franchisereoffice (required).</param>
        /// <param name="sFranchisereferalincomeRemoteid">sFranchisereferalincomeRemoteid (required).</param>
        public FranchisereferalincomeRequestCompound(AddressRequest objAddress = default(AddressRequest), List<ContactRequestCompound> aObjContact = default(List<ContactRequestCompound>), int fkiFranchisebrokerID = default(int), int fkiFranchisereferalincomeprogramID = default(int), int fkiPeriodID = default(int), string dFranchisereferalincomeLoan = default(string), string dFranchisereferalincomeFranchiseamount = default(string), string dFranchisereferalincomeFranchisoramount = default(string), string dFranchisereferalincomeAgentamount = default(string), string dtFranchisereferalincomeDisbursed = default(string), string tFranchisereferalincomeComment = default(string), int fkiFranchiseofficeID = default(int), string sFranchisereferalincomeRemoteid = default(string))
        {
            // to ensure "aObjContact" is required (not null)
            if (aObjContact == null)
            {
                throw new InvalidDataException("aObjContact is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.a_objContact = aObjContact;
            }
            
            // to ensure "fkiFranchisebrokerID" is required (not null)
            if (fkiFranchisebrokerID == null)
            {
                throw new InvalidDataException("fkiFranchisebrokerID is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.fkiFranchisebrokerID = fkiFranchisebrokerID;
            }
            
            // to ensure "fkiFranchisereferalincomeprogramID" is required (not null)
            if (fkiFranchisereferalincomeprogramID == null)
            {
                throw new InvalidDataException("fkiFranchisereferalincomeprogramID is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.fkiFranchisereferalincomeprogramID = fkiFranchisereferalincomeprogramID;
            }
            
            // to ensure "fkiPeriodID" is required (not null)
            if (fkiPeriodID == null)
            {
                throw new InvalidDataException("fkiPeriodID is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.fkiPeriodID = fkiPeriodID;
            }
            
            // to ensure "dFranchisereferalincomeLoan" is required (not null)
            if (dFranchisereferalincomeLoan == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeLoan is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.dFranchisereferalincomeLoan = dFranchisereferalincomeLoan;
            }
            
            // to ensure "dFranchisereferalincomeFranchiseamount" is required (not null)
            if (dFranchisereferalincomeFranchiseamount == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeFranchiseamount is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.dFranchisereferalincomeFranchiseamount = dFranchisereferalincomeFranchiseamount;
            }
            
            // to ensure "dFranchisereferalincomeFranchisoramount" is required (not null)
            if (dFranchisereferalincomeFranchisoramount == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeFranchisoramount is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.dFranchisereferalincomeFranchisoramount = dFranchisereferalincomeFranchisoramount;
            }
            
            // to ensure "dFranchisereferalincomeAgentamount" is required (not null)
            if (dFranchisereferalincomeAgentamount == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeAgentamount is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.dFranchisereferalincomeAgentamount = dFranchisereferalincomeAgentamount;
            }
            
            // to ensure "dtFranchisereferalincomeDisbursed" is required (not null)
            if (dtFranchisereferalincomeDisbursed == null)
            {
                throw new InvalidDataException("dtFranchisereferalincomeDisbursed is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.dtFranchisereferalincomeDisbursed = dtFranchisereferalincomeDisbursed;
            }
            
            // to ensure "tFranchisereferalincomeComment" is required (not null)
            if (tFranchisereferalincomeComment == null)
            {
                throw new InvalidDataException("tFranchisereferalincomeComment is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.tFranchisereferalincomeComment = tFranchisereferalincomeComment;
            }
            
            // to ensure "fkiFranchiseofficeID" is required (not null)
            if (fkiFranchiseofficeID == null)
            {
                throw new InvalidDataException("fkiFranchiseofficeID is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.fkiFranchiseofficeID = fkiFranchiseofficeID;
            }
            
            // to ensure "sFranchisereferalincomeRemoteid" is required (not null)
            if (sFranchisereferalincomeRemoteid == null)
            {
                throw new InvalidDataException("sFranchisereferalincomeRemoteid is a required property for FranchisereferalincomeRequestCompound and cannot be null");
            }
            else
            {
                this.sFranchisereferalincomeRemoteid = sFranchisereferalincomeRemoteid;
            }
            
            this.objAddress = objAddress;
        }
        
        /// <summary>
        /// Gets or Sets objAddress
        /// </summary>
        [DataMember(Name="objAddress", EmitDefaultValue=false)]
        public AddressRequest objAddress { get; set; }

        /// <summary>
        /// Gets or Sets a_objContact
        /// </summary>
        [DataMember(Name="a_objContact", EmitDefaultValue=true)]
        public List<ContactRequestCompound> a_objContact { get; set; }

        /// <summary>
        /// The unique ID of the Franchisebroker
        /// </summary>
        /// <value>The unique ID of the Franchisebroker</value>
        [DataMember(Name="fkiFranchisebrokerID", EmitDefaultValue=true)]
        public int fkiFranchisebrokerID { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereferalincomeprogram
        /// </summary>
        /// <value>The unique ID of the Franchisereferalincomeprogram</value>
        [DataMember(Name="fkiFranchisereferalincomeprogramID", EmitDefaultValue=true)]
        public int fkiFranchisereferalincomeprogramID { get; set; }

        /// <summary>
        /// The unique ID of the Period
        /// </summary>
        /// <value>The unique ID of the Period</value>
        [DataMember(Name="fkiPeriodID", EmitDefaultValue=true)]
        public int fkiPeriodID { get; set; }

        /// <summary>
        /// The loan amount
        /// </summary>
        /// <value>The loan amount</value>
        [DataMember(Name="dFranchisereferalincomeLoan", EmitDefaultValue=true)]
        public string dFranchisereferalincomeLoan { get; set; }

        /// <summary>
        /// The amount that will be given to the franchise
        /// </summary>
        /// <value>The amount that will be given to the franchise</value>
        [DataMember(Name="dFranchisereferalincomeFranchiseamount", EmitDefaultValue=true)]
        public string dFranchisereferalincomeFranchiseamount { get; set; }

        /// <summary>
        /// The amount that will be kept by the franchisor
        /// </summary>
        /// <value>The amount that will be kept by the franchisor</value>
        [DataMember(Name="dFranchisereferalincomeFranchisoramount", EmitDefaultValue=true)]
        public string dFranchisereferalincomeFranchisoramount { get; set; }

        /// <summary>
        /// The amount that will be given to the agent
        /// </summary>
        /// <value>The amount that will be given to the agent</value>
        [DataMember(Name="dFranchisereferalincomeAgentamount", EmitDefaultValue=true)]
        public string dFranchisereferalincomeAgentamount { get; set; }

        /// <summary>
        /// The date the amounts were disbursed
        /// </summary>
        /// <value>The date the amounts were disbursed</value>
        [DataMember(Name="dtFranchisereferalincomeDisbursed", EmitDefaultValue=true)]
        public string dtFranchisereferalincomeDisbursed { get; set; }

        /// <summary>
        /// A comment about the transaction
        /// </summary>
        /// <value>A comment about the transaction</value>
        [DataMember(Name="tFranchisereferalincomeComment", EmitDefaultValue=true)]
        public string tFranchisereferalincomeComment { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereoffice
        /// </summary>
        /// <value>The unique ID of the Franchisereoffice</value>
        [DataMember(Name="fkiFranchiseofficeID", EmitDefaultValue=true)]
        public int fkiFranchiseofficeID { get; set; }

        /// <summary>
        /// Gets or Sets sFranchisereferalincomeRemoteid
        /// </summary>
        [DataMember(Name="sFranchisereferalincomeRemoteid", EmitDefaultValue=true)]
        public string sFranchisereferalincomeRemoteid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeRequestCompound {\n");
            sb.Append("  objAddress: ").Append(objAddress).Append("\n");
            sb.Append("  a_objContact: ").Append(a_objContact).Append("\n");
            sb.Append("  fkiFranchisebrokerID: ").Append(fkiFranchisebrokerID).Append("\n");
            sb.Append("  fkiFranchisereferalincomeprogramID: ").Append(fkiFranchisereferalincomeprogramID).Append("\n");
            sb.Append("  fkiPeriodID: ").Append(fkiPeriodID).Append("\n");
            sb.Append("  dFranchisereferalincomeLoan: ").Append(dFranchisereferalincomeLoan).Append("\n");
            sb.Append("  dFranchisereferalincomeFranchiseamount: ").Append(dFranchisereferalincomeFranchiseamount).Append("\n");
            sb.Append("  dFranchisereferalincomeFranchisoramount: ").Append(dFranchisereferalincomeFranchisoramount).Append("\n");
            sb.Append("  dFranchisereferalincomeAgentamount: ").Append(dFranchisereferalincomeAgentamount).Append("\n");
            sb.Append("  dtFranchisereferalincomeDisbursed: ").Append(dtFranchisereferalincomeDisbursed).Append("\n");
            sb.Append("  tFranchisereferalincomeComment: ").Append(tFranchisereferalincomeComment).Append("\n");
            sb.Append("  fkiFranchiseofficeID: ").Append(fkiFranchiseofficeID).Append("\n");
            sb.Append("  sFranchisereferalincomeRemoteid: ").Append(sFranchisereferalincomeRemoteid).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeRequestCompound);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objAddress == input.objAddress ||
                    (this.objAddress != null &&
                    this.objAddress.Equals(input.objAddress))
                ) && 
                (
                    this.a_objContact == input.a_objContact ||
                    this.a_objContact != null &&
                    input.a_objContact != null &&
                    this.a_objContact.SequenceEqual(input.a_objContact)
                ) && 
                (
                    this.fkiFranchisebrokerID == input.fkiFranchisebrokerID ||
                    (this.fkiFranchisebrokerID != null &&
                    this.fkiFranchisebrokerID.Equals(input.fkiFranchisebrokerID))
                ) && 
                (
                    this.fkiFranchisereferalincomeprogramID == input.fkiFranchisereferalincomeprogramID ||
                    (this.fkiFranchisereferalincomeprogramID != null &&
                    this.fkiFranchisereferalincomeprogramID.Equals(input.fkiFranchisereferalincomeprogramID))
                ) && 
                (
                    this.fkiPeriodID == input.fkiPeriodID ||
                    (this.fkiPeriodID != null &&
                    this.fkiPeriodID.Equals(input.fkiPeriodID))
                ) && 
                (
                    this.dFranchisereferalincomeLoan == input.dFranchisereferalincomeLoan ||
                    (this.dFranchisereferalincomeLoan != null &&
                    this.dFranchisereferalincomeLoan.Equals(input.dFranchisereferalincomeLoan))
                ) && 
                (
                    this.dFranchisereferalincomeFranchiseamount == input.dFranchisereferalincomeFranchiseamount ||
                    (this.dFranchisereferalincomeFranchiseamount != null &&
                    this.dFranchisereferalincomeFranchiseamount.Equals(input.dFranchisereferalincomeFranchiseamount))
                ) && 
                (
                    this.dFranchisereferalincomeFranchisoramount == input.dFranchisereferalincomeFranchisoramount ||
                    (this.dFranchisereferalincomeFranchisoramount != null &&
                    this.dFranchisereferalincomeFranchisoramount.Equals(input.dFranchisereferalincomeFranchisoramount))
                ) && 
                (
                    this.dFranchisereferalincomeAgentamount == input.dFranchisereferalincomeAgentamount ||
                    (this.dFranchisereferalincomeAgentamount != null &&
                    this.dFranchisereferalincomeAgentamount.Equals(input.dFranchisereferalincomeAgentamount))
                ) && 
                (
                    this.dtFranchisereferalincomeDisbursed == input.dtFranchisereferalincomeDisbursed ||
                    (this.dtFranchisereferalincomeDisbursed != null &&
                    this.dtFranchisereferalincomeDisbursed.Equals(input.dtFranchisereferalincomeDisbursed))
                ) && 
                (
                    this.tFranchisereferalincomeComment == input.tFranchisereferalincomeComment ||
                    (this.tFranchisereferalincomeComment != null &&
                    this.tFranchisereferalincomeComment.Equals(input.tFranchisereferalincomeComment))
                ) && 
                (
                    this.fkiFranchiseofficeID == input.fkiFranchiseofficeID ||
                    (this.fkiFranchiseofficeID != null &&
                    this.fkiFranchiseofficeID.Equals(input.fkiFranchiseofficeID))
                ) && 
                (
                    this.sFranchisereferalincomeRemoteid == input.sFranchisereferalincomeRemoteid ||
                    (this.sFranchisereferalincomeRemoteid != null &&
                    this.sFranchisereferalincomeRemoteid.Equals(input.sFranchisereferalincomeRemoteid))
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
                if (this.objAddress != null)
                    hashCode = hashCode * 59 + this.objAddress.GetHashCode();
                if (this.a_objContact != null)
                    hashCode = hashCode * 59 + this.a_objContact.GetHashCode();
                if (this.fkiFranchisebrokerID != null)
                    hashCode = hashCode * 59 + this.fkiFranchisebrokerID.GetHashCode();
                if (this.fkiFranchisereferalincomeprogramID != null)
                    hashCode = hashCode * 59 + this.fkiFranchisereferalincomeprogramID.GetHashCode();
                if (this.fkiPeriodID != null)
                    hashCode = hashCode * 59 + this.fkiPeriodID.GetHashCode();
                if (this.dFranchisereferalincomeLoan != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeLoan.GetHashCode();
                if (this.dFranchisereferalincomeFranchiseamount != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeFranchiseamount.GetHashCode();
                if (this.dFranchisereferalincomeFranchisoramount != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeFranchisoramount.GetHashCode();
                if (this.dFranchisereferalincomeAgentamount != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeAgentamount.GetHashCode();
                if (this.dtFranchisereferalincomeDisbursed != null)
                    hashCode = hashCode * 59 + this.dtFranchisereferalincomeDisbursed.GetHashCode();
                if (this.tFranchisereferalincomeComment != null)
                    hashCode = hashCode * 59 + this.tFranchisereferalincomeComment.GetHashCode();
                if (this.fkiFranchiseofficeID != null)
                    hashCode = hashCode * 59 + this.fkiFranchiseofficeID.GetHashCode();
                if (this.sFranchisereferalincomeRemoteid != null)
                    hashCode = hashCode * 59 + this.sFranchisereferalincomeRemoteid.GetHashCode();
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
