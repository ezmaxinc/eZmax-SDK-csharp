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
    /// EzsigndocumentResponseAllOf
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentResponseAllOf :  IEquatable<EzsigndocumentResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentResponseAllOf" /> class.
        /// </summary>
        /// <param name="fkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsigndocumentDuedate">The maximum date and time at which the document can be signed. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEzsigndocumentName">The name of the document that will be presented to Ezsignfoldersignerassociations (required).</param>
        /// <param name="pkiEzsigndocumentID">The unique ID of the Ezsigntemplate (required).</param>
        /// <param name="eEzsigndocumentStep">eEzsigndocumentStep (required).</param>
        /// <param name="dtEzsigndocumentFirstsend">The date and time when the Ezsigndocument was first sent. (required).</param>
        /// <param name="dtEzsigndocumentLastsend">The date and time when the Ezsigndocument was sent the last time. (required).</param>
        /// <param name="iEzsigndocumentOrder">The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder. (required).</param>
        /// <param name="iEzsigndocumentPagetotal">The number of pages in the Ezsigndocument. (required).</param>
        /// <param name="iEzsigndocumentSignaturesigned">The number of signatures that were signed in the document. (required).</param>
        /// <param name="iEzsigndocumentSignaturetotal">The number of total signatures that were requested in the Ezsigndocument. (required).</param>
        /// <param name="sEzsigndocumentMD5initial">MD5 Hash of the initial PDF Document before signatures were applied to it. (required).</param>
        /// <param name="sEzsigndocumentMD5signed">MD5 Hash of the final PDF Document after all signatures were applied to it. (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public EzsigndocumentResponseAllOf(int fkiEzsignfolderID = default(int), string dtEzsigndocumentDuedate = default(string), int fkiLanguageID = default(int), string sEzsigndocumentName = default(string), int pkiEzsigndocumentID = default(int), FieldEEzsigndocumentStep eEzsigndocumentStep = default(FieldEEzsigndocumentStep), string dtEzsigndocumentFirstsend = default(string), string dtEzsigndocumentLastsend = default(string), int iEzsigndocumentOrder = default(int), int iEzsigndocumentPagetotal = default(int), int iEzsigndocumentSignaturesigned = default(int), int iEzsigndocumentSignaturetotal = default(int), string sEzsigndocumentMD5initial = default(string), string sEzsigndocumentMD5signed = default(string), CommonAudit objAudit = default(CommonAudit))
        {
            // to ensure "fkiEzsignfolderID" is required (not null)
            if (fkiEzsignfolderID == null)
            {
                throw new InvalidDataException("fkiEzsignfolderID is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.FkiEzsignfolderID = fkiEzsignfolderID;
            }

            // to ensure "dtEzsigndocumentDuedate" is required (not null)
            if (dtEzsigndocumentDuedate == null)
            {
                throw new InvalidDataException("dtEzsigndocumentDuedate is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.DtEzsigndocumentDuedate = dtEzsigndocumentDuedate;
            }

            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.FkiLanguageID = fkiLanguageID;
            }

            // to ensure "sEzsigndocumentName" is required (not null)
            if (sEzsigndocumentName == null)
            {
                throw new InvalidDataException("sEzsigndocumentName is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.SEzsigndocumentName = sEzsigndocumentName;
            }

            // to ensure "pkiEzsigndocumentID" is required (not null)
            if (pkiEzsigndocumentID == null)
            {
                throw new InvalidDataException("pkiEzsigndocumentID is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.PkiEzsigndocumentID = pkiEzsigndocumentID;
            }

            // to ensure "eEzsigndocumentStep" is required (not null)
            if (eEzsigndocumentStep == null)
            {
                throw new InvalidDataException("eEzsigndocumentStep is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.EEzsigndocumentStep = eEzsigndocumentStep;
            }

            // to ensure "dtEzsigndocumentFirstsend" is required (not null)
            if (dtEzsigndocumentFirstsend == null)
            {
                throw new InvalidDataException("dtEzsigndocumentFirstsend is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.DtEzsigndocumentFirstsend = dtEzsigndocumentFirstsend;
            }

            // to ensure "dtEzsigndocumentLastsend" is required (not null)
            if (dtEzsigndocumentLastsend == null)
            {
                throw new InvalidDataException("dtEzsigndocumentLastsend is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.DtEzsigndocumentLastsend = dtEzsigndocumentLastsend;
            }

            // to ensure "iEzsigndocumentOrder" is required (not null)
            if (iEzsigndocumentOrder == null)
            {
                throw new InvalidDataException("iEzsigndocumentOrder is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.IEzsigndocumentOrder = iEzsigndocumentOrder;
            }

            // to ensure "iEzsigndocumentPagetotal" is required (not null)
            if (iEzsigndocumentPagetotal == null)
            {
                throw new InvalidDataException("iEzsigndocumentPagetotal is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.IEzsigndocumentPagetotal = iEzsigndocumentPagetotal;
            }

            // to ensure "iEzsigndocumentSignaturesigned" is required (not null)
            if (iEzsigndocumentSignaturesigned == null)
            {
                throw new InvalidDataException("iEzsigndocumentSignaturesigned is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.IEzsigndocumentSignaturesigned = iEzsigndocumentSignaturesigned;
            }

            // to ensure "iEzsigndocumentSignaturetotal" is required (not null)
            if (iEzsigndocumentSignaturetotal == null)
            {
                throw new InvalidDataException("iEzsigndocumentSignaturetotal is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.IEzsigndocumentSignaturetotal = iEzsigndocumentSignaturetotal;
            }

            // to ensure "sEzsigndocumentMD5initial" is required (not null)
            if (sEzsigndocumentMD5initial == null)
            {
                throw new InvalidDataException("sEzsigndocumentMD5initial is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.SEzsigndocumentMD5initial = sEzsigndocumentMD5initial;
            }

            // to ensure "sEzsigndocumentMD5signed" is required (not null)
            if (sEzsigndocumentMD5signed == null)
            {
                throw new InvalidDataException("sEzsigndocumentMD5signed is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.SEzsigndocumentMD5signed = sEzsigndocumentMD5signed;
            }

            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new InvalidDataException("objAudit is a required property for EzsigndocumentResponseAllOf and cannot be null");
            }
            else
            {
                this.ObjAudit = objAudit;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name="fkiEzsignfolderID", EmitDefaultValue=true)]
        public int FkiEzsignfolderID { get; set; }

        /// <summary>
        /// The maximum date and time at which the document can be signed.
        /// </summary>
        /// <value>The maximum date and time at which the document can be signed.</value>
        [DataMember(Name="dtEzsigndocumentDuedate", EmitDefaultValue=true)]
        public string DtEzsigndocumentDuedate { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// The name of the document that will be presented to Ezsignfoldersignerassociations
        /// </summary>
        /// <value>The name of the document that will be presented to Ezsignfoldersignerassociations</value>
        [DataMember(Name="sEzsigndocumentName", EmitDefaultValue=true)]
        public string SEzsigndocumentName { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name="pkiEzsigndocumentID", EmitDefaultValue=true)]
        public int PkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Gets or Sets EEzsigndocumentStep
        /// </summary>
        [DataMember(Name="eEzsigndocumentStep", EmitDefaultValue=true)]
        public FieldEEzsigndocumentStep EEzsigndocumentStep { get; set; }

        /// <summary>
        /// The date and time when the Ezsigndocument was first sent.
        /// </summary>
        /// <value>The date and time when the Ezsigndocument was first sent.</value>
        [DataMember(Name="dtEzsigndocumentFirstsend", EmitDefaultValue=true)]
        public string DtEzsigndocumentFirstsend { get; set; }

        /// <summary>
        /// The date and time when the Ezsigndocument was sent the last time.
        /// </summary>
        /// <value>The date and time when the Ezsigndocument was sent the last time.</value>
        [DataMember(Name="dtEzsigndocumentLastsend", EmitDefaultValue=true)]
        public string DtEzsigndocumentLastsend { get; set; }

        /// <summary>
        /// The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder.
        /// </summary>
        /// <value>The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder.</value>
        [DataMember(Name="iEzsigndocumentOrder", EmitDefaultValue=true)]
        public int IEzsigndocumentOrder { get; set; }

        /// <summary>
        /// The number of pages in the Ezsigndocument.
        /// </summary>
        /// <value>The number of pages in the Ezsigndocument.</value>
        [DataMember(Name="iEzsigndocumentPagetotal", EmitDefaultValue=true)]
        public int IEzsigndocumentPagetotal { get; set; }

        /// <summary>
        /// The number of signatures that were signed in the document.
        /// </summary>
        /// <value>The number of signatures that were signed in the document.</value>
        [DataMember(Name="iEzsigndocumentSignaturesigned", EmitDefaultValue=true)]
        public int IEzsigndocumentSignaturesigned { get; set; }

        /// <summary>
        /// The number of total signatures that were requested in the Ezsigndocument.
        /// </summary>
        /// <value>The number of total signatures that were requested in the Ezsigndocument.</value>
        [DataMember(Name="iEzsigndocumentSignaturetotal", EmitDefaultValue=true)]
        public int IEzsigndocumentSignaturetotal { get; set; }

        /// <summary>
        /// MD5 Hash of the initial PDF Document before signatures were applied to it.
        /// </summary>
        /// <value>MD5 Hash of the initial PDF Document before signatures were applied to it.</value>
        [DataMember(Name="sEzsigndocumentMD5initial", EmitDefaultValue=true)]
        public string SEzsigndocumentMD5initial { get; set; }

        /// <summary>
        /// MD5 Hash of the final PDF Document after all signatures were applied to it.
        /// </summary>
        /// <value>MD5 Hash of the final PDF Document after all signatures were applied to it.</value>
        [DataMember(Name="sEzsigndocumentMD5signed", EmitDefaultValue=true)]
        public string SEzsigndocumentMD5signed { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name="objAudit", EmitDefaultValue=true)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentResponseAllOf {\n");
            sb.Append("  FkiEzsignfolderID: ").Append(FkiEzsignfolderID).Append("\n");
            sb.Append("  DtEzsigndocumentDuedate: ").Append(DtEzsigndocumentDuedate).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SEzsigndocumentName: ").Append(SEzsigndocumentName).Append("\n");
            sb.Append("  PkiEzsigndocumentID: ").Append(PkiEzsigndocumentID).Append("\n");
            sb.Append("  EEzsigndocumentStep: ").Append(EEzsigndocumentStep).Append("\n");
            sb.Append("  DtEzsigndocumentFirstsend: ").Append(DtEzsigndocumentFirstsend).Append("\n");
            sb.Append("  DtEzsigndocumentLastsend: ").Append(DtEzsigndocumentLastsend).Append("\n");
            sb.Append("  IEzsigndocumentOrder: ").Append(IEzsigndocumentOrder).Append("\n");
            sb.Append("  IEzsigndocumentPagetotal: ").Append(IEzsigndocumentPagetotal).Append("\n");
            sb.Append("  IEzsigndocumentSignaturesigned: ").Append(IEzsigndocumentSignaturesigned).Append("\n");
            sb.Append("  IEzsigndocumentSignaturetotal: ").Append(IEzsigndocumentSignaturetotal).Append("\n");
            sb.Append("  SEzsigndocumentMD5initial: ").Append(SEzsigndocumentMD5initial).Append("\n");
            sb.Append("  SEzsigndocumentMD5signed: ").Append(SEzsigndocumentMD5signed).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
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
            return this.Equals(input as EzsigndocumentResponseAllOf);
        }

        /// <summary>
        /// Returns true if EzsigndocumentResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsignfolderID == input.FkiEzsignfolderID ||
                    (this.FkiEzsignfolderID != null &&
                    this.FkiEzsignfolderID.Equals(input.FkiEzsignfolderID))
                ) && 
                (
                    this.DtEzsigndocumentDuedate == input.DtEzsigndocumentDuedate ||
                    (this.DtEzsigndocumentDuedate != null &&
                    this.DtEzsigndocumentDuedate.Equals(input.DtEzsigndocumentDuedate))
                ) && 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    (this.FkiLanguageID != null &&
                    this.FkiLanguageID.Equals(input.FkiLanguageID))
                ) && 
                (
                    this.SEzsigndocumentName == input.SEzsigndocumentName ||
                    (this.SEzsigndocumentName != null &&
                    this.SEzsigndocumentName.Equals(input.SEzsigndocumentName))
                ) && 
                (
                    this.PkiEzsigndocumentID == input.PkiEzsigndocumentID ||
                    (this.PkiEzsigndocumentID != null &&
                    this.PkiEzsigndocumentID.Equals(input.PkiEzsigndocumentID))
                ) && 
                (
                    this.EEzsigndocumentStep == input.EEzsigndocumentStep ||
                    (this.EEzsigndocumentStep != null &&
                    this.EEzsigndocumentStep.Equals(input.EEzsigndocumentStep))
                ) && 
                (
                    this.DtEzsigndocumentFirstsend == input.DtEzsigndocumentFirstsend ||
                    (this.DtEzsigndocumentFirstsend != null &&
                    this.DtEzsigndocumentFirstsend.Equals(input.DtEzsigndocumentFirstsend))
                ) && 
                (
                    this.DtEzsigndocumentLastsend == input.DtEzsigndocumentLastsend ||
                    (this.DtEzsigndocumentLastsend != null &&
                    this.DtEzsigndocumentLastsend.Equals(input.DtEzsigndocumentLastsend))
                ) && 
                (
                    this.IEzsigndocumentOrder == input.IEzsigndocumentOrder ||
                    (this.IEzsigndocumentOrder != null &&
                    this.IEzsigndocumentOrder.Equals(input.IEzsigndocumentOrder))
                ) && 
                (
                    this.IEzsigndocumentPagetotal == input.IEzsigndocumentPagetotal ||
                    (this.IEzsigndocumentPagetotal != null &&
                    this.IEzsigndocumentPagetotal.Equals(input.IEzsigndocumentPagetotal))
                ) && 
                (
                    this.IEzsigndocumentSignaturesigned == input.IEzsigndocumentSignaturesigned ||
                    (this.IEzsigndocumentSignaturesigned != null &&
                    this.IEzsigndocumentSignaturesigned.Equals(input.IEzsigndocumentSignaturesigned))
                ) && 
                (
                    this.IEzsigndocumentSignaturetotal == input.IEzsigndocumentSignaturetotal ||
                    (this.IEzsigndocumentSignaturetotal != null &&
                    this.IEzsigndocumentSignaturetotal.Equals(input.IEzsigndocumentSignaturetotal))
                ) && 
                (
                    this.SEzsigndocumentMD5initial == input.SEzsigndocumentMD5initial ||
                    (this.SEzsigndocumentMD5initial != null &&
                    this.SEzsigndocumentMD5initial.Equals(input.SEzsigndocumentMD5initial))
                ) && 
                (
                    this.SEzsigndocumentMD5signed == input.SEzsigndocumentMD5signed ||
                    (this.SEzsigndocumentMD5signed != null &&
                    this.SEzsigndocumentMD5signed.Equals(input.SEzsigndocumentMD5signed))
                ) && 
                (
                    this.ObjAudit == input.ObjAudit ||
                    (this.ObjAudit != null &&
                    this.ObjAudit.Equals(input.ObjAudit))
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
                if (this.FkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfolderID.GetHashCode();
                if (this.DtEzsigndocumentDuedate != null)
                    hashCode = hashCode * 59 + this.DtEzsigndocumentDuedate.GetHashCode();
                if (this.FkiLanguageID != null)
                    hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.SEzsigndocumentName != null)
                    hashCode = hashCode * 59 + this.SEzsigndocumentName.GetHashCode();
                if (this.PkiEzsigndocumentID != null)
                    hashCode = hashCode * 59 + this.PkiEzsigndocumentID.GetHashCode();
                if (this.EEzsigndocumentStep != null)
                    hashCode = hashCode * 59 + this.EEzsigndocumentStep.GetHashCode();
                if (this.DtEzsigndocumentFirstsend != null)
                    hashCode = hashCode * 59 + this.DtEzsigndocumentFirstsend.GetHashCode();
                if (this.DtEzsigndocumentLastsend != null)
                    hashCode = hashCode * 59 + this.DtEzsigndocumentLastsend.GetHashCode();
                if (this.IEzsigndocumentOrder != null)
                    hashCode = hashCode * 59 + this.IEzsigndocumentOrder.GetHashCode();
                if (this.IEzsigndocumentPagetotal != null)
                    hashCode = hashCode * 59 + this.IEzsigndocumentPagetotal.GetHashCode();
                if (this.IEzsigndocumentSignaturesigned != null)
                    hashCode = hashCode * 59 + this.IEzsigndocumentSignaturesigned.GetHashCode();
                if (this.IEzsigndocumentSignaturetotal != null)
                    hashCode = hashCode * 59 + this.IEzsigndocumentSignaturetotal.GetHashCode();
                if (this.SEzsigndocumentMD5initial != null)
                    hashCode = hashCode * 59 + this.SEzsigndocumentMD5initial.GetHashCode();
                if (this.SEzsigndocumentMD5signed != null)
                    hashCode = hashCode * 59 + this.SEzsigndocumentMD5signed.GetHashCode();
                if (this.ObjAudit != null)
                    hashCode = hashCode * 59 + this.ObjAudit.GetHashCode();
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
