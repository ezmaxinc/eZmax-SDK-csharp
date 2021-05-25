/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.43
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
    /// An Franchisereferalincome Object
    /// </summary>
    [DataContract]
    public partial class FranchisereferalincomeRequest :  IEquatable<FranchisereferalincomeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchisereferalincomeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequest" /> class.
        /// </summary>
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
        public FranchisereferalincomeRequest(int fkiFranchisebrokerID = default(int), int fkiFranchisereferalincomeprogramID = default(int), int fkiPeriodID = default(int), string dFranchisereferalincomeLoan = default(string), string dFranchisereferalincomeFranchiseamount = default(string), string dFranchisereferalincomeFranchisoramount = default(string), string dFranchisereferalincomeAgentamount = default(string), string dtFranchisereferalincomeDisbursed = default(string), string tFranchisereferalincomeComment = default(string), int fkiFranchiseofficeID = default(int), string sFranchisereferalincomeRemoteid = default(string))
        {
            // to ensure "fkiFranchisebrokerID" is required (not null)
            if (fkiFranchisebrokerID == null)
            {
                throw new InvalidDataException("fkiFranchisebrokerID is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.FkiFranchisebrokerID = fkiFranchisebrokerID;
            }

            // to ensure "fkiFranchisereferalincomeprogramID" is required (not null)
            if (fkiFranchisereferalincomeprogramID == null)
            {
                throw new InvalidDataException("fkiFranchisereferalincomeprogramID is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.FkiFranchisereferalincomeprogramID = fkiFranchisereferalincomeprogramID;
            }

            // to ensure "fkiPeriodID" is required (not null)
            if (fkiPeriodID == null)
            {
                throw new InvalidDataException("fkiPeriodID is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.FkiPeriodID = fkiPeriodID;
            }

            // to ensure "dFranchisereferalincomeLoan" is required (not null)
            if (dFranchisereferalincomeLoan == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeLoan is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.DFranchisereferalincomeLoan = dFranchisereferalincomeLoan;
            }

            // to ensure "dFranchisereferalincomeFranchiseamount" is required (not null)
            if (dFranchisereferalincomeFranchiseamount == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeFranchiseamount is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.DFranchisereferalincomeFranchiseamount = dFranchisereferalincomeFranchiseamount;
            }

            // to ensure "dFranchisereferalincomeFranchisoramount" is required (not null)
            if (dFranchisereferalincomeFranchisoramount == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeFranchisoramount is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.DFranchisereferalincomeFranchisoramount = dFranchisereferalincomeFranchisoramount;
            }

            // to ensure "dFranchisereferalincomeAgentamount" is required (not null)
            if (dFranchisereferalincomeAgentamount == null)
            {
                throw new InvalidDataException("dFranchisereferalincomeAgentamount is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.DFranchisereferalincomeAgentamount = dFranchisereferalincomeAgentamount;
            }

            // to ensure "dtFranchisereferalincomeDisbursed" is required (not null)
            if (dtFranchisereferalincomeDisbursed == null)
            {
                throw new InvalidDataException("dtFranchisereferalincomeDisbursed is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.DtFranchisereferalincomeDisbursed = dtFranchisereferalincomeDisbursed;
            }

            // to ensure "tFranchisereferalincomeComment" is required (not null)
            if (tFranchisereferalincomeComment == null)
            {
                throw new InvalidDataException("tFranchisereferalincomeComment is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.TFranchisereferalincomeComment = tFranchisereferalincomeComment;
            }

            // to ensure "fkiFranchiseofficeID" is required (not null)
            if (fkiFranchiseofficeID == null)
            {
                throw new InvalidDataException("fkiFranchiseofficeID is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.FkiFranchiseofficeID = fkiFranchiseofficeID;
            }

            // to ensure "sFranchisereferalincomeRemoteid" is required (not null)
            if (sFranchisereferalincomeRemoteid == null)
            {
                throw new InvalidDataException("sFranchisereferalincomeRemoteid is a required property for FranchisereferalincomeRequest and cannot be null");
            }
            else
            {
                this.SFranchisereferalincomeRemoteid = sFranchisereferalincomeRemoteid;
            }

        }

        /// <summary>
        /// The unique ID of the Franchisebroker
        /// </summary>
        /// <value>The unique ID of the Franchisebroker</value>
        [DataMember(Name="fkiFranchisebrokerID", EmitDefaultValue=true)]
        public int FkiFranchisebrokerID { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereferalincomeprogram
        /// </summary>
        /// <value>The unique ID of the Franchisereferalincomeprogram</value>
        [DataMember(Name="fkiFranchisereferalincomeprogramID", EmitDefaultValue=true)]
        public int FkiFranchisereferalincomeprogramID { get; set; }

        /// <summary>
        /// The unique ID of the Period
        /// </summary>
        /// <value>The unique ID of the Period</value>
        [DataMember(Name="fkiPeriodID", EmitDefaultValue=true)]
        public int FkiPeriodID { get; set; }

        /// <summary>
        /// The loan amount
        /// </summary>
        /// <value>The loan amount</value>
        [DataMember(Name="dFranchisereferalincomeLoan", EmitDefaultValue=true)]
        public string DFranchisereferalincomeLoan { get; set; }

        /// <summary>
        /// The amount that will be given to the franchise
        /// </summary>
        /// <value>The amount that will be given to the franchise</value>
        [DataMember(Name="dFranchisereferalincomeFranchiseamount", EmitDefaultValue=true)]
        public string DFranchisereferalincomeFranchiseamount { get; set; }

        /// <summary>
        /// The amount that will be kept by the franchisor
        /// </summary>
        /// <value>The amount that will be kept by the franchisor</value>
        [DataMember(Name="dFranchisereferalincomeFranchisoramount", EmitDefaultValue=true)]
        public string DFranchisereferalincomeFranchisoramount { get; set; }

        /// <summary>
        /// The amount that will be given to the agent
        /// </summary>
        /// <value>The amount that will be given to the agent</value>
        [DataMember(Name="dFranchisereferalincomeAgentamount", EmitDefaultValue=true)]
        public string DFranchisereferalincomeAgentamount { get; set; }

        /// <summary>
        /// The date the amounts were disbursed
        /// </summary>
        /// <value>The date the amounts were disbursed</value>
        [DataMember(Name="dtFranchisereferalincomeDisbursed", EmitDefaultValue=true)]
        public string DtFranchisereferalincomeDisbursed { get; set; }

        /// <summary>
        /// A comment about the transaction
        /// </summary>
        /// <value>A comment about the transaction</value>
        [DataMember(Name="tFranchisereferalincomeComment", EmitDefaultValue=true)]
        public string TFranchisereferalincomeComment { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereoffice
        /// </summary>
        /// <value>The unique ID of the Franchisereoffice</value>
        [DataMember(Name="fkiFranchiseofficeID", EmitDefaultValue=true)]
        public int FkiFranchiseofficeID { get; set; }

        /// <summary>
        /// Gets or Sets SFranchisereferalincomeRemoteid
        /// </summary>
        [DataMember(Name="sFranchisereferalincomeRemoteid", EmitDefaultValue=true)]
        public string SFranchisereferalincomeRemoteid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeRequest {\n");
            sb.Append("  FkiFranchisebrokerID: ").Append(FkiFranchisebrokerID).Append("\n");
            sb.Append("  FkiFranchisereferalincomeprogramID: ").Append(FkiFranchisereferalincomeprogramID).Append("\n");
            sb.Append("  FkiPeriodID: ").Append(FkiPeriodID).Append("\n");
            sb.Append("  DFranchisereferalincomeLoan: ").Append(DFranchisereferalincomeLoan).Append("\n");
            sb.Append("  DFranchisereferalincomeFranchiseamount: ").Append(DFranchisereferalincomeFranchiseamount).Append("\n");
            sb.Append("  DFranchisereferalincomeFranchisoramount: ").Append(DFranchisereferalincomeFranchisoramount).Append("\n");
            sb.Append("  DFranchisereferalincomeAgentamount: ").Append(DFranchisereferalincomeAgentamount).Append("\n");
            sb.Append("  DtFranchisereferalincomeDisbursed: ").Append(DtFranchisereferalincomeDisbursed).Append("\n");
            sb.Append("  TFranchisereferalincomeComment: ").Append(TFranchisereferalincomeComment).Append("\n");
            sb.Append("  FkiFranchiseofficeID: ").Append(FkiFranchiseofficeID).Append("\n");
            sb.Append("  SFranchisereferalincomeRemoteid: ").Append(SFranchisereferalincomeRemoteid).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeRequest);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiFranchisebrokerID == input.FkiFranchisebrokerID ||
                    (this.FkiFranchisebrokerID != null &&
                    this.FkiFranchisebrokerID.Equals(input.FkiFranchisebrokerID))
                ) && 
                (
                    this.FkiFranchisereferalincomeprogramID == input.FkiFranchisereferalincomeprogramID ||
                    (this.FkiFranchisereferalincomeprogramID != null &&
                    this.FkiFranchisereferalincomeprogramID.Equals(input.FkiFranchisereferalincomeprogramID))
                ) && 
                (
                    this.FkiPeriodID == input.FkiPeriodID ||
                    (this.FkiPeriodID != null &&
                    this.FkiPeriodID.Equals(input.FkiPeriodID))
                ) && 
                (
                    this.DFranchisereferalincomeLoan == input.DFranchisereferalincomeLoan ||
                    (this.DFranchisereferalincomeLoan != null &&
                    this.DFranchisereferalincomeLoan.Equals(input.DFranchisereferalincomeLoan))
                ) && 
                (
                    this.DFranchisereferalincomeFranchiseamount == input.DFranchisereferalincomeFranchiseamount ||
                    (this.DFranchisereferalincomeFranchiseamount != null &&
                    this.DFranchisereferalincomeFranchiseamount.Equals(input.DFranchisereferalincomeFranchiseamount))
                ) && 
                (
                    this.DFranchisereferalincomeFranchisoramount == input.DFranchisereferalincomeFranchisoramount ||
                    (this.DFranchisereferalincomeFranchisoramount != null &&
                    this.DFranchisereferalincomeFranchisoramount.Equals(input.DFranchisereferalincomeFranchisoramount))
                ) && 
                (
                    this.DFranchisereferalincomeAgentamount == input.DFranchisereferalincomeAgentamount ||
                    (this.DFranchisereferalincomeAgentamount != null &&
                    this.DFranchisereferalincomeAgentamount.Equals(input.DFranchisereferalincomeAgentamount))
                ) && 
                (
                    this.DtFranchisereferalincomeDisbursed == input.DtFranchisereferalincomeDisbursed ||
                    (this.DtFranchisereferalincomeDisbursed != null &&
                    this.DtFranchisereferalincomeDisbursed.Equals(input.DtFranchisereferalincomeDisbursed))
                ) && 
                (
                    this.TFranchisereferalincomeComment == input.TFranchisereferalincomeComment ||
                    (this.TFranchisereferalincomeComment != null &&
                    this.TFranchisereferalincomeComment.Equals(input.TFranchisereferalincomeComment))
                ) && 
                (
                    this.FkiFranchiseofficeID == input.FkiFranchiseofficeID ||
                    (this.FkiFranchiseofficeID != null &&
                    this.FkiFranchiseofficeID.Equals(input.FkiFranchiseofficeID))
                ) && 
                (
                    this.SFranchisereferalincomeRemoteid == input.SFranchisereferalincomeRemoteid ||
                    (this.SFranchisereferalincomeRemoteid != null &&
                    this.SFranchisereferalincomeRemoteid.Equals(input.SFranchisereferalincomeRemoteid))
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
                if (this.FkiFranchisebrokerID != null)
                    hashCode = hashCode * 59 + this.FkiFranchisebrokerID.GetHashCode();
                if (this.FkiFranchisereferalincomeprogramID != null)
                    hashCode = hashCode * 59 + this.FkiFranchisereferalincomeprogramID.GetHashCode();
                if (this.FkiPeriodID != null)
                    hashCode = hashCode * 59 + this.FkiPeriodID.GetHashCode();
                if (this.DFranchisereferalincomeLoan != null)
                    hashCode = hashCode * 59 + this.DFranchisereferalincomeLoan.GetHashCode();
                if (this.DFranchisereferalincomeFranchiseamount != null)
                    hashCode = hashCode * 59 + this.DFranchisereferalincomeFranchiseamount.GetHashCode();
                if (this.DFranchisereferalincomeFranchisoramount != null)
                    hashCode = hashCode * 59 + this.DFranchisereferalincomeFranchisoramount.GetHashCode();
                if (this.DFranchisereferalincomeAgentamount != null)
                    hashCode = hashCode * 59 + this.DFranchisereferalincomeAgentamount.GetHashCode();
                if (this.DtFranchisereferalincomeDisbursed != null)
                    hashCode = hashCode * 59 + this.DtFranchisereferalincomeDisbursed.GetHashCode();
                if (this.TFranchisereferalincomeComment != null)
                    hashCode = hashCode * 59 + this.TFranchisereferalincomeComment.GetHashCode();
                if (this.FkiFranchiseofficeID != null)
                    hashCode = hashCode * 59 + this.FkiFranchiseofficeID.GetHashCode();
                if (this.SFranchisereferalincomeRemoteid != null)
                    hashCode = hashCode * 59 + this.SFranchisereferalincomeRemoteid.GetHashCode();
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
