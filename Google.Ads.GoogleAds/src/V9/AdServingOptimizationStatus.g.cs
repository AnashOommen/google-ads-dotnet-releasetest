// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/ad_serving_optimization_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/ad_serving_optimization_status.proto</summary>
  public static partial class AdServingOptimizationStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/ad_serving_optimization_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdServingOptimizationStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9hZF9zZXJ2aW5nX29w",
            "dGltaXphdGlvbl9zdGF0dXMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY5LmVudW1zIrwBCh9BZFNlcnZpbmdPcHRpbWl6YXRpb25TdGF0dXNFbnVt",
            "IpgBChtBZFNlcnZpbmdPcHRpbWl6YXRpb25TdGF0dXMSDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESDAoIT1BUSU1JWkUQAhIXChNDT05WRVJTSU9O",
            "X09QVElNSVpFEAMSCgoGUk9UQVRFEAQSFwoTUk9UQVRFX0lOREVGSU5JVEVM",
            "WRAFEg8KC1VOQVZBSUxBQkxFEAZC9QEKIWNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52OS5lbnVtc0IgQWRTZXJ2aW5nT3B0aW1pemF0aW9uU3RhdHVzUHJv",
            "dG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3Y5L2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjkuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "OVxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.AdServingOptimizationStatusEnum), global::Google.Ads.GoogleAds.V9.Enums.AdServingOptimizationStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Possible ad serving statuses of a campaign.
  /// </summary>
  public sealed partial class AdServingOptimizationStatusEnum : pb::IMessage<AdServingOptimizationStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdServingOptimizationStatusEnum> _parser = new pb::MessageParser<AdServingOptimizationStatusEnum>(() => new AdServingOptimizationStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdServingOptimizationStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.AdServingOptimizationStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdServingOptimizationStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdServingOptimizationStatusEnum(AdServingOptimizationStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdServingOptimizationStatusEnum Clone() {
      return new AdServingOptimizationStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdServingOptimizationStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdServingOptimizationStatusEnum other) {
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
    public void MergeFrom(AdServingOptimizationStatusEnum other) {
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
    /// <summary>Container for nested types declared in the AdServingOptimizationStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible serving statuses.
      /// </summary>
      public enum AdServingOptimizationStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Ad serving is optimized based on CTR for the campaign.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE")] Optimize = 2,
        /// <summary>
        /// Ad serving is optimized based on CTR * Conversion for the campaign. If
        /// the campaign is not in the conversion optimizer bidding strategy, it will
        /// default to OPTIMIZED.
        /// </summary>
        [pbr::OriginalName("CONVERSION_OPTIMIZE")] ConversionOptimize = 3,
        /// <summary>
        /// Ads are rotated evenly for 90 days, then optimized for clicks.
        /// </summary>
        [pbr::OriginalName("ROTATE")] Rotate = 4,
        /// <summary>
        /// Show lower performing ads more evenly with higher performing ads, and do
        /// not optimize.
        /// </summary>
        [pbr::OriginalName("ROTATE_INDEFINITELY")] RotateIndefinitely = 5,
        /// <summary>
        /// Ad serving optimization status is not available.
        /// </summary>
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
