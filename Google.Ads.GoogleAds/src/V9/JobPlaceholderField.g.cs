// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/job_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/job_placeholder_field.proto</summary>
  public static partial class JobPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/job_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JobPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9qb2JfcGxhY2Vob2xk",
            "ZXJfZmllbGQucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVudW1z",
            "IvECChdKb2JQbGFjZWhvbGRlckZpZWxkRW51bSLVAgoTSm9iUGxhY2Vob2xk",
            "ZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZKT0Jf",
            "SUQQAhIPCgtMT0NBVElPTl9JRBADEgkKBVRJVExFEAQSDAoIU1VCVElUTEUQ",
            "BRIPCgtERVNDUklQVElPThAGEg0KCUlNQUdFX1VSTBAHEgwKCENBVEVHT1JZ",
            "EAgSFwoTQ09OVEVYVFVBTF9LRVlXT1JEUxAJEgsKB0FERFJFU1MQChIKCgZT",
            "QUxBUlkQCxIOCgpGSU5BTF9VUkxTEAwSFQoRRklOQUxfTU9CSUxFX1VSTFMQ",
            "DhIQCgxUUkFDS0lOR19VUkwQDxIUChBBTkRST0lEX0FQUF9MSU5LEBASEwoP",
            "U0lNSUxBUl9KT0JfSURTEBESEAoMSU9TX0FQUF9MSU5LEBISFAoQSU9TX0FQ",
            "UF9TVE9SRV9JRBATQu4BCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjku",
            "ZW51bXNCGUpvYnNQbGFjZWhvbGRlckZpZWxkUHJvdG9QAVpCZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5",
            "L2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjku",
            "RW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxFbnVtc+oCIUdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.JobPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V9.Enums.JobPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.JobPlaceholderFieldEnum.Types.JobPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Job placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class JobPlaceholderFieldEnum : pb::IMessage<JobPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JobPlaceholderFieldEnum> _parser = new pb::MessageParser<JobPlaceholderFieldEnum>(() => new JobPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JobPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.JobPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JobPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JobPlaceholderFieldEnum(JobPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JobPlaceholderFieldEnum Clone() {
      return new JobPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JobPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JobPlaceholderFieldEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JobPlaceholderFieldEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the JobPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Job placeholder fields.
      /// </summary>
      public enum JobPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Required. If only JOB_ID is specified, then it must be
        /// unique. If both JOB_ID and LOCATION_ID are specified, then the
        /// pair must be unique.
        /// ID) pair must be unique.
        /// </summary>
        [pbr::OriginalName("JOB_ID")] JobId = 2,
        /// <summary>
        /// Data Type: STRING. Combination of JOB_ID and LOCATION_ID must be unique
        /// per offer.
        /// </summary>
        [pbr::OriginalName("LOCATION_ID")] LocationId = 3,
        /// <summary>
        /// Data Type: STRING. Required. Main headline with job title to be shown in
        /// dynamic ad.
        /// </summary>
        [pbr::OriginalName("TITLE")] Title = 4,
        /// <summary>
        /// Data Type: STRING. Job subtitle to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("SUBTITLE")] Subtitle = 5,
        /// <summary>
        /// Data Type: STRING. Description of job to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION")] Description = 6,
        /// <summary>
        /// Data Type: URL. Image to be displayed in the ad. Highly recommended for
        /// image ads.
        /// </summary>
        [pbr::OriginalName("IMAGE_URL")] ImageUrl = 7,
        /// <summary>
        /// Data Type: STRING. Category of property used to group like items together
        /// for recommendation engine.
        /// </summary>
        [pbr::OriginalName("CATEGORY")] Category = 8,
        /// <summary>
        /// Data Type: STRING_LIST. Keywords used for product retrieval.
        /// </summary>
        [pbr::OriginalName("CONTEXTUAL_KEYWORDS")] ContextualKeywords = 9,
        /// <summary>
        /// Data Type: STRING. Complete property address, including postal code.
        /// </summary>
        [pbr::OriginalName("ADDRESS")] Address = 10,
        /// <summary>
        /// Data Type: STRING. Salary or salary range of job to be shown in dynamic
        /// ad.
        /// </summary>
        [pbr::OriginalName("SALARY")] Salary = 11,
        /// <summary>
        /// Data Type: URL_LIST. Required. Final URLs to be used in ad when using
        /// Upgraded URLs; the more specific the better (e.g. the individual URL of a
        /// specific job and its location).
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 12,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 14,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 15,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 16,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended job IDs to show together with
        /// this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_JOB_IDS")] SimilarJobIds = 17,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 18,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
