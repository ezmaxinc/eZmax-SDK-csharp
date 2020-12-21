/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.23
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
    /// An Ezsigndocument Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentResponseCompound :  IEquatable<EzsigndocumentResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentResponseCompound" /> class.
        /// </summary>
        /// <param name="fkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsigndocumentDuedate">The maximum date and time at which the document can be signed. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEzsigndocumentFilename">The actual file name that will be used when downloading or attaching to an email. (required).</param>
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
        /// <param name="fkiUserIDCreated">The id of the User that created the object. (required).</param>
        /// <param name="fkiUserIDModified">The id of the User that made the last modification on the object. (required).</param>
        /// <param name="fkiApikeyIDCreated">The id of the API Key that created the object..</param>
        /// <param name="fkiApikeyIDModified">The id of the API Key that made the last modification on the object..</param>
        /// <param name="dtCreatedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="dtModifiedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        public EzsigndocumentResponseCompound(int fkiEzsignfolderID = default(int), string dtEzsigndocumentDuedate = default(string), int fkiLanguageID = default(int), string sEzsigndocumentFilename = default(string), string sEzsigndocumentName = default(string), int pkiEzsigndocumentID = default(int), FieldEEzsigndocumentStep eEzsigndocumentStep = default(FieldEEzsigndocumentStep), string dtEzsigndocumentFirstsend = default(string), string dtEzsigndocumentLastsend = default(string), int iEzsigndocumentOrder = default(int), int iEzsigndocumentPagetotal = default(int), int iEzsigndocumentSignaturesigned = default(int), int iEzsigndocumentSignaturetotal = default(int), string sEzsigndocumentMD5initial = default(string), string sEzsigndocumentMD5signed = default(string), int fkiUserIDCreated = default(int), int fkiUserIDModified = default(int), int fkiApikeyIDCreated = default(int), int fkiApikeyIDModified = default(int), string dtCreatedDate = default(string), string dtModifiedDate = default(string))
        {
            // to ensure "fkiEzsignfolderID" is required (not null)
            if (fkiEzsignfolderID == null)
            {
                throw new InvalidDataException("fkiEzsignfolderID is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.fkiEzsignfolderID = fkiEzsignfolderID;
            }
            
            // to ensure "dtEzsigndocumentDuedate" is required (not null)
            if (dtEzsigndocumentDuedate == null)
            {
                throw new InvalidDataException("dtEzsigndocumentDuedate is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.dtEzsigndocumentDuedate = dtEzsigndocumentDuedate;
            }
            
            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.fkiLanguageID = fkiLanguageID;
            }
            
            // to ensure "sEzsigndocumentFilename" is required (not null)
            if (sEzsigndocumentFilename == null)
            {
                throw new InvalidDataException("sEzsigndocumentFilename is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.sEzsigndocumentFilename = sEzsigndocumentFilename;
            }
            
            // to ensure "sEzsigndocumentName" is required (not null)
            if (sEzsigndocumentName == null)
            {
                throw new InvalidDataException("sEzsigndocumentName is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.sEzsigndocumentName = sEzsigndocumentName;
            }
            
            // to ensure "pkiEzsigndocumentID" is required (not null)
            if (pkiEzsigndocumentID == null)
            {
                throw new InvalidDataException("pkiEzsigndocumentID is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.pkiEzsigndocumentID = pkiEzsigndocumentID;
            }
            
            // to ensure "eEzsigndocumentStep" is required (not null)
            if (eEzsigndocumentStep == null)
            {
                throw new InvalidDataException("eEzsigndocumentStep is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.eEzsigndocumentStep = eEzsigndocumentStep;
            }
            
            // to ensure "dtEzsigndocumentFirstsend" is required (not null)
            if (dtEzsigndocumentFirstsend == null)
            {
                throw new InvalidDataException("dtEzsigndocumentFirstsend is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.dtEzsigndocumentFirstsend = dtEzsigndocumentFirstsend;
            }
            
            // to ensure "dtEzsigndocumentLastsend" is required (not null)
            if (dtEzsigndocumentLastsend == null)
            {
                throw new InvalidDataException("dtEzsigndocumentLastsend is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.dtEzsigndocumentLastsend = dtEzsigndocumentLastsend;
            }
            
            // to ensure "iEzsigndocumentOrder" is required (not null)
            if (iEzsigndocumentOrder == null)
            {
                throw new InvalidDataException("iEzsigndocumentOrder is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.iEzsigndocumentOrder = iEzsigndocumentOrder;
            }
            
            // to ensure "iEzsigndocumentPagetotal" is required (not null)
            if (iEzsigndocumentPagetotal == null)
            {
                throw new InvalidDataException("iEzsigndocumentPagetotal is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.iEzsigndocumentPagetotal = iEzsigndocumentPagetotal;
            }
            
            // to ensure "iEzsigndocumentSignaturesigned" is required (not null)
            if (iEzsigndocumentSignaturesigned == null)
            {
                throw new InvalidDataException("iEzsigndocumentSignaturesigned is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.iEzsigndocumentSignaturesigned = iEzsigndocumentSignaturesigned;
            }
            
            // to ensure "iEzsigndocumentSignaturetotal" is required (not null)
            if (iEzsigndocumentSignaturetotal == null)
            {
                throw new InvalidDataException("iEzsigndocumentSignaturetotal is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.iEzsigndocumentSignaturetotal = iEzsigndocumentSignaturetotal;
            }
            
            // to ensure "sEzsigndocumentMD5initial" is required (not null)
            if (sEzsigndocumentMD5initial == null)
            {
                throw new InvalidDataException("sEzsigndocumentMD5initial is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.sEzsigndocumentMD5initial = sEzsigndocumentMD5initial;
            }
            
            // to ensure "sEzsigndocumentMD5signed" is required (not null)
            if (sEzsigndocumentMD5signed == null)
            {
                throw new InvalidDataException("sEzsigndocumentMD5signed is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.sEzsigndocumentMD5signed = sEzsigndocumentMD5signed;
            }
            
            // to ensure "fkiUserIDCreated" is required (not null)
            if (fkiUserIDCreated == null)
            {
                throw new InvalidDataException("fkiUserIDCreated is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.fkiUserIDCreated = fkiUserIDCreated;
            }
            
            // to ensure "fkiUserIDModified" is required (not null)
            if (fkiUserIDModified == null)
            {
                throw new InvalidDataException("fkiUserIDModified is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.fkiUserIDModified = fkiUserIDModified;
            }
            
            // to ensure "dtCreatedDate" is required (not null)
            if (dtCreatedDate == null)
            {
                throw new InvalidDataException("dtCreatedDate is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.dtCreatedDate = dtCreatedDate;
            }
            
            // to ensure "dtModifiedDate" is required (not null)
            if (dtModifiedDate == null)
            {
                throw new InvalidDataException("dtModifiedDate is a required property for EzsigndocumentResponseCompound and cannot be null");
            }
            else
            {
                this.dtModifiedDate = dtModifiedDate;
            }
            
            this.fkiApikeyIDCreated = fkiApikeyIDCreated;
            this.fkiApikeyIDModified = fkiApikeyIDModified;
        }
        
        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name="fkiEzsignfolderID", EmitDefaultValue=true)]
        public int fkiEzsignfolderID { get; set; }

        /// <summary>
        /// The maximum date and time at which the document can be signed.
        /// </summary>
        /// <value>The maximum date and time at which the document can be signed.</value>
        [DataMember(Name="dtEzsigndocumentDuedate", EmitDefaultValue=true)]
        public string dtEzsigndocumentDuedate { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// The actual file name that will be used when downloading or attaching to an email.
        /// </summary>
        /// <value>The actual file name that will be used when downloading or attaching to an email.</value>
        [DataMember(Name="sEzsigndocumentFilename", EmitDefaultValue=true)]
        public string sEzsigndocumentFilename { get; set; }

        /// <summary>
        /// The name of the document that will be presented to Ezsignfoldersignerassociations
        /// </summary>
        /// <value>The name of the document that will be presented to Ezsignfoldersignerassociations</value>
        [DataMember(Name="sEzsigndocumentName", EmitDefaultValue=true)]
        public string sEzsigndocumentName { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name="pkiEzsigndocumentID", EmitDefaultValue=true)]
        public int pkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Gets or Sets eEzsigndocumentStep
        /// </summary>
        [DataMember(Name="eEzsigndocumentStep", EmitDefaultValue=true)]
        public FieldEEzsigndocumentStep eEzsigndocumentStep { get; set; }

        /// <summary>
        /// The date and time when the Ezsigndocument was first sent.
        /// </summary>
        /// <value>The date and time when the Ezsigndocument was first sent.</value>
        [DataMember(Name="dtEzsigndocumentFirstsend", EmitDefaultValue=true)]
        public string dtEzsigndocumentFirstsend { get; set; }

        /// <summary>
        /// The date and time when the Ezsigndocument was sent the last time.
        /// </summary>
        /// <value>The date and time when the Ezsigndocument was sent the last time.</value>
        [DataMember(Name="dtEzsigndocumentLastsend", EmitDefaultValue=true)]
        public string dtEzsigndocumentLastsend { get; set; }

        /// <summary>
        /// The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder.
        /// </summary>
        /// <value>The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder.</value>
        [DataMember(Name="iEzsigndocumentOrder", EmitDefaultValue=true)]
        public int iEzsigndocumentOrder { get; set; }

        /// <summary>
        /// The number of pages in the Ezsigndocument.
        /// </summary>
        /// <value>The number of pages in the Ezsigndocument.</value>
        [DataMember(Name="iEzsigndocumentPagetotal", EmitDefaultValue=true)]
        public int iEzsigndocumentPagetotal { get; set; }

        /// <summary>
        /// The number of signatures that were signed in the document.
        /// </summary>
        /// <value>The number of signatures that were signed in the document.</value>
        [DataMember(Name="iEzsigndocumentSignaturesigned", EmitDefaultValue=true)]
        public int iEzsigndocumentSignaturesigned { get; set; }

        /// <summary>
        /// The number of total signatures that were requested in the Ezsigndocument.
        /// </summary>
        /// <value>The number of total signatures that were requested in the Ezsigndocument.</value>
        [DataMember(Name="iEzsigndocumentSignaturetotal", EmitDefaultValue=true)]
        public int iEzsigndocumentSignaturetotal { get; set; }

        /// <summary>
        /// MD5 Hash of the initial PDF Document before signatures were applied to it.
        /// </summary>
        /// <value>MD5 Hash of the initial PDF Document before signatures were applied to it.</value>
        [DataMember(Name="sEzsigndocumentMD5initial", EmitDefaultValue=true)]
        public string sEzsigndocumentMD5initial { get; set; }

        /// <summary>
        /// MD5 Hash of the final PDF Document after all signatures were applied to it.
        /// </summary>
        /// <value>MD5 Hash of the final PDF Document after all signatures were applied to it.</value>
        [DataMember(Name="sEzsigndocumentMD5signed", EmitDefaultValue=true)]
        public string sEzsigndocumentMD5signed { get; set; }

        /// <summary>
        /// The id of the User that created the object.
        /// </summary>
        /// <value>The id of the User that created the object.</value>
        [DataMember(Name="fkiUserIDCreated", EmitDefaultValue=true)]
        public int fkiUserIDCreated { get; set; }

        /// <summary>
        /// The id of the User that made the last modification on the object.
        /// </summary>
        /// <value>The id of the User that made the last modification on the object.</value>
        [DataMember(Name="fkiUserIDModified", EmitDefaultValue=true)]
        public int fkiUserIDModified { get; set; }

        /// <summary>
        /// The id of the API Key that created the object.
        /// </summary>
        /// <value>The id of the API Key that created the object.</value>
        [DataMember(Name="fkiApikeyIDCreated", EmitDefaultValue=false)]
        public int fkiApikeyIDCreated { get; set; }

        /// <summary>
        /// The id of the API Key that made the last modification on the object.
        /// </summary>
        /// <value>The id of the API Key that made the last modification on the object.</value>
        [DataMember(Name="fkiApikeyIDModified", EmitDefaultValue=false)]
        public int fkiApikeyIDModified { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name="dtCreatedDate", EmitDefaultValue=true)]
        public string dtCreatedDate { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name="dtModifiedDate", EmitDefaultValue=true)]
        public string dtModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentResponseCompound {\n");
            sb.Append("  fkiEzsignfolderID: ").Append(fkiEzsignfolderID).Append("\n");
            sb.Append("  dtEzsigndocumentDuedate: ").Append(dtEzsigndocumentDuedate).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sEzsigndocumentFilename: ").Append(sEzsigndocumentFilename).Append("\n");
            sb.Append("  sEzsigndocumentName: ").Append(sEzsigndocumentName).Append("\n");
            sb.Append("  pkiEzsigndocumentID: ").Append(pkiEzsigndocumentID).Append("\n");
            sb.Append("  eEzsigndocumentStep: ").Append(eEzsigndocumentStep).Append("\n");
            sb.Append("  dtEzsigndocumentFirstsend: ").Append(dtEzsigndocumentFirstsend).Append("\n");
            sb.Append("  dtEzsigndocumentLastsend: ").Append(dtEzsigndocumentLastsend).Append("\n");
            sb.Append("  iEzsigndocumentOrder: ").Append(iEzsigndocumentOrder).Append("\n");
            sb.Append("  iEzsigndocumentPagetotal: ").Append(iEzsigndocumentPagetotal).Append("\n");
            sb.Append("  iEzsigndocumentSignaturesigned: ").Append(iEzsigndocumentSignaturesigned).Append("\n");
            sb.Append("  iEzsigndocumentSignaturetotal: ").Append(iEzsigndocumentSignaturetotal).Append("\n");
            sb.Append("  sEzsigndocumentMD5initial: ").Append(sEzsigndocumentMD5initial).Append("\n");
            sb.Append("  sEzsigndocumentMD5signed: ").Append(sEzsigndocumentMD5signed).Append("\n");
            sb.Append("  fkiUserIDCreated: ").Append(fkiUserIDCreated).Append("\n");
            sb.Append("  fkiUserIDModified: ").Append(fkiUserIDModified).Append("\n");
            sb.Append("  fkiApikeyIDCreated: ").Append(fkiApikeyIDCreated).Append("\n");
            sb.Append("  fkiApikeyIDModified: ").Append(fkiApikeyIDModified).Append("\n");
            sb.Append("  dtCreatedDate: ").Append(dtCreatedDate).Append("\n");
            sb.Append("  dtModifiedDate: ").Append(dtModifiedDate).Append("\n");
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
            return this.Equals(input as EzsigndocumentResponseCompound);
        }

        /// <summary>
        /// Returns true if EzsigndocumentResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentResponseCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiEzsignfolderID == input.fkiEzsignfolderID ||
                    (this.fkiEzsignfolderID != null &&
                    this.fkiEzsignfolderID.Equals(input.fkiEzsignfolderID))
                ) && 
                (
                    this.dtEzsigndocumentDuedate == input.dtEzsigndocumentDuedate ||
                    (this.dtEzsigndocumentDuedate != null &&
                    this.dtEzsigndocumentDuedate.Equals(input.dtEzsigndocumentDuedate))
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    (this.fkiLanguageID != null &&
                    this.fkiLanguageID.Equals(input.fkiLanguageID))
                ) && 
                (
                    this.sEzsigndocumentFilename == input.sEzsigndocumentFilename ||
                    (this.sEzsigndocumentFilename != null &&
                    this.sEzsigndocumentFilename.Equals(input.sEzsigndocumentFilename))
                ) && 
                (
                    this.sEzsigndocumentName == input.sEzsigndocumentName ||
                    (this.sEzsigndocumentName != null &&
                    this.sEzsigndocumentName.Equals(input.sEzsigndocumentName))
                ) && 
                (
                    this.pkiEzsigndocumentID == input.pkiEzsigndocumentID ||
                    (this.pkiEzsigndocumentID != null &&
                    this.pkiEzsigndocumentID.Equals(input.pkiEzsigndocumentID))
                ) && 
                (
                    this.eEzsigndocumentStep == input.eEzsigndocumentStep ||
                    (this.eEzsigndocumentStep != null &&
                    this.eEzsigndocumentStep.Equals(input.eEzsigndocumentStep))
                ) && 
                (
                    this.dtEzsigndocumentFirstsend == input.dtEzsigndocumentFirstsend ||
                    (this.dtEzsigndocumentFirstsend != null &&
                    this.dtEzsigndocumentFirstsend.Equals(input.dtEzsigndocumentFirstsend))
                ) && 
                (
                    this.dtEzsigndocumentLastsend == input.dtEzsigndocumentLastsend ||
                    (this.dtEzsigndocumentLastsend != null &&
                    this.dtEzsigndocumentLastsend.Equals(input.dtEzsigndocumentLastsend))
                ) && 
                (
                    this.iEzsigndocumentOrder == input.iEzsigndocumentOrder ||
                    (this.iEzsigndocumentOrder != null &&
                    this.iEzsigndocumentOrder.Equals(input.iEzsigndocumentOrder))
                ) && 
                (
                    this.iEzsigndocumentPagetotal == input.iEzsigndocumentPagetotal ||
                    (this.iEzsigndocumentPagetotal != null &&
                    this.iEzsigndocumentPagetotal.Equals(input.iEzsigndocumentPagetotal))
                ) && 
                (
                    this.iEzsigndocumentSignaturesigned == input.iEzsigndocumentSignaturesigned ||
                    (this.iEzsigndocumentSignaturesigned != null &&
                    this.iEzsigndocumentSignaturesigned.Equals(input.iEzsigndocumentSignaturesigned))
                ) && 
                (
                    this.iEzsigndocumentSignaturetotal == input.iEzsigndocumentSignaturetotal ||
                    (this.iEzsigndocumentSignaturetotal != null &&
                    this.iEzsigndocumentSignaturetotal.Equals(input.iEzsigndocumentSignaturetotal))
                ) && 
                (
                    this.sEzsigndocumentMD5initial == input.sEzsigndocumentMD5initial ||
                    (this.sEzsigndocumentMD5initial != null &&
                    this.sEzsigndocumentMD5initial.Equals(input.sEzsigndocumentMD5initial))
                ) && 
                (
                    this.sEzsigndocumentMD5signed == input.sEzsigndocumentMD5signed ||
                    (this.sEzsigndocumentMD5signed != null &&
                    this.sEzsigndocumentMD5signed.Equals(input.sEzsigndocumentMD5signed))
                ) && 
                (
                    this.fkiUserIDCreated == input.fkiUserIDCreated ||
                    (this.fkiUserIDCreated != null &&
                    this.fkiUserIDCreated.Equals(input.fkiUserIDCreated))
                ) && 
                (
                    this.fkiUserIDModified == input.fkiUserIDModified ||
                    (this.fkiUserIDModified != null &&
                    this.fkiUserIDModified.Equals(input.fkiUserIDModified))
                ) && 
                (
                    this.fkiApikeyIDCreated == input.fkiApikeyIDCreated ||
                    (this.fkiApikeyIDCreated != null &&
                    this.fkiApikeyIDCreated.Equals(input.fkiApikeyIDCreated))
                ) && 
                (
                    this.fkiApikeyIDModified == input.fkiApikeyIDModified ||
                    (this.fkiApikeyIDModified != null &&
                    this.fkiApikeyIDModified.Equals(input.fkiApikeyIDModified))
                ) && 
                (
                    this.dtCreatedDate == input.dtCreatedDate ||
                    (this.dtCreatedDate != null &&
                    this.dtCreatedDate.Equals(input.dtCreatedDate))
                ) && 
                (
                    this.dtModifiedDate == input.dtModifiedDate ||
                    (this.dtModifiedDate != null &&
                    this.dtModifiedDate.Equals(input.dtModifiedDate))
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
                if (this.fkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.fkiEzsignfolderID.GetHashCode();
                if (this.dtEzsigndocumentDuedate != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentDuedate.GetHashCode();
                if (this.fkiLanguageID != null)
                    hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sEzsigndocumentFilename != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentFilename.GetHashCode();
                if (this.sEzsigndocumentName != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentName.GetHashCode();
                if (this.pkiEzsigndocumentID != null)
                    hashCode = hashCode * 59 + this.pkiEzsigndocumentID.GetHashCode();
                if (this.eEzsigndocumentStep != null)
                    hashCode = hashCode * 59 + this.eEzsigndocumentStep.GetHashCode();
                if (this.dtEzsigndocumentFirstsend != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentFirstsend.GetHashCode();
                if (this.dtEzsigndocumentLastsend != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentLastsend.GetHashCode();
                if (this.iEzsigndocumentOrder != null)
                    hashCode = hashCode * 59 + this.iEzsigndocumentOrder.GetHashCode();
                if (this.iEzsigndocumentPagetotal != null)
                    hashCode = hashCode * 59 + this.iEzsigndocumentPagetotal.GetHashCode();
                if (this.iEzsigndocumentSignaturesigned != null)
                    hashCode = hashCode * 59 + this.iEzsigndocumentSignaturesigned.GetHashCode();
                if (this.iEzsigndocumentSignaturetotal != null)
                    hashCode = hashCode * 59 + this.iEzsigndocumentSignaturetotal.GetHashCode();
                if (this.sEzsigndocumentMD5initial != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentMD5initial.GetHashCode();
                if (this.sEzsigndocumentMD5signed != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentMD5signed.GetHashCode();
                if (this.fkiUserIDCreated != null)
                    hashCode = hashCode * 59 + this.fkiUserIDCreated.GetHashCode();
                if (this.fkiUserIDModified != null)
                    hashCode = hashCode * 59 + this.fkiUserIDModified.GetHashCode();
                if (this.fkiApikeyIDCreated != null)
                    hashCode = hashCode * 59 + this.fkiApikeyIDCreated.GetHashCode();
                if (this.fkiApikeyIDModified != null)
                    hashCode = hashCode * 59 + this.fkiApikeyIDModified.GetHashCode();
                if (this.dtCreatedDate != null)
                    hashCode = hashCode * 59 + this.dtCreatedDate.GetHashCode();
                if (this.dtModifiedDate != null)
                    hashCode = hashCode * 59 + this.dtModifiedDate.GetHashCode();
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
