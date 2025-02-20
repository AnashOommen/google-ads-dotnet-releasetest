// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/services/invoice_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/services/invoice_service.proto</summary>
  public static partial class InvoiceServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/services/invoice_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvoiceServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9zZXJ2aWNlcy9pbnZvaWNlX3Nl",
            "cnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnNlcnZpY2Vz",
            "GjFnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9tb250aF9vZl95ZWFy",
            "LnByb3RvGi9nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvaW52",
            "b2ljZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29v",
            "Z2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8iugEKE0xpc3RJbnZvaWNlc1JlcXVlc3QSGAoLY3VzdG9tZXJf",
            "aWQYASABKAlCA+BBAhIaCg1iaWxsaW5nX3NldHVwGAIgASgJQgPgQQISFwoK",
            "aXNzdWVfeWVhchgDIAEoCUID4EECElQKC2lzc3VlX21vbnRoGAQgASgOMjou",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMuTW9udGhPZlllYXJFbnVt",
            "Lk1vbnRoT2ZZZWFyQgPgQQIiVAoUTGlzdEludm9pY2VzUmVzcG9uc2USPAoI",
            "aW52b2ljZXMYASADKAsyKi5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNv",
            "dXJjZXMuSW52b2ljZTK6AgoOSW52b2ljZVNlcnZpY2US4AEKDExpc3RJbnZv",
            "aWNlcxI1Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnNlcnZpY2VzLkxpc3RJ",
            "bnZvaWNlc1JlcXVlc3QaNi5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5zZXJ2",
            "aWNlcy5MaXN0SW52b2ljZXNSZXNwb25zZSJhgtPkkwIoEiYvdjkvY3VzdG9t",
            "ZXJzL3tjdXN0b21lcl9pZD0qfS9pbnZvaWNlc9pBMGN1c3RvbWVyX2lkLGJp",
            "bGxpbmdfc2V0dXAsaXNzdWVfeWVhcixpc3N1ZV9tb250aBpFykEYZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29t0kEnaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5j",
            "b20vYXV0aC9hZHdvcmRzQvoBCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djkuc2VydmljZXNCE0ludm9pY2VTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5",
            "L3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjkuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxTZXJ2",
            "aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpTZXJ2aWNlc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Resources.InvoiceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Services.ListInvoicesRequest), global::Google.Ads.GoogleAds.V9.Services.ListInvoicesRequest.Parser, new[]{ "CustomerId", "BillingSetup", "IssueYear", "IssueMonth" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Services.ListInvoicesResponse), global::Google.Ads.GoogleAds.V9.Services.ListInvoicesResponse.Parser, new[]{ "Invoices" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for fetching the invoices of a given billing setup that were
  /// issued during a given month.
  /// </summary>
  public sealed partial class ListInvoicesRequest : pb::IMessage<ListInvoicesRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListInvoicesRequest> _parser = new pb::MessageParser<ListInvoicesRequest>(() => new ListInvoicesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListInvoicesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Services.InvoiceServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListInvoicesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListInvoicesRequest(ListInvoicesRequest other) : this() {
      customerId_ = other.customerId_;
      billingSetup_ = other.billingSetup_;
      issueYear_ = other.issueYear_;
      issueMonth_ = other.issueMonth_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListInvoicesRequest Clone() {
      return new ListInvoicesRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer to fetch invoices for.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "billing_setup" field.</summary>
    public const int BillingSetupFieldNumber = 2;
    private string billingSetup_ = "";
    /// <summary>
    /// Required. The billing setup resource name of the requested invoices.
    ///
    /// `customers/{customer_id}/billingSetups/{billing_setup_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BillingSetup {
      get { return billingSetup_; }
      set {
        billingSetup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "issue_year" field.</summary>
    public const int IssueYearFieldNumber = 3;
    private string issueYear_ = "";
    /// <summary>
    /// Required. The issue year to retrieve invoices, in yyyy format. Only
    /// invoices issued in 2019 or later can be retrieved.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IssueYear {
      get { return issueYear_; }
      set {
        issueYear_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "issue_month" field.</summary>
    public const int IssueMonthFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear issueMonth_ = global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified;
    /// <summary>
    /// Required. The issue month to retrieve invoices.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear IssueMonth {
      get { return issueMonth_; }
      set {
        issueMonth_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListInvoicesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListInvoicesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (BillingSetup != other.BillingSetup) return false;
      if (IssueYear != other.IssueYear) return false;
      if (IssueMonth != other.IssueMonth) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (BillingSetup.Length != 0) hash ^= BillingSetup.GetHashCode();
      if (IssueYear.Length != 0) hash ^= IssueYear.GetHashCode();
      if (IssueMonth != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) hash ^= IssueMonth.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (BillingSetup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BillingSetup);
      }
      if (IssueYear.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IssueYear);
      }
      if (IssueMonth != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) IssueMonth);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (BillingSetup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BillingSetup);
      }
      if (IssueYear.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IssueYear);
      }
      if (IssueMonth != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) IssueMonth);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (BillingSetup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BillingSetup);
      }
      if (IssueYear.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IssueYear);
      }
      if (IssueMonth != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IssueMonth);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListInvoicesRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.BillingSetup.Length != 0) {
        BillingSetup = other.BillingSetup;
      }
      if (other.IssueYear.Length != 0) {
        IssueYear = other.IssueYear;
      }
      if (other.IssueMonth != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        IssueMonth = other.IssueMonth;
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
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            BillingSetup = input.ReadString();
            break;
          }
          case 26: {
            IssueYear = input.ReadString();
            break;
          }
          case 32: {
            IssueMonth = (global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear) input.ReadEnum();
            break;
          }
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
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            BillingSetup = input.ReadString();
            break;
          }
          case 26: {
            IssueYear = input.ReadString();
            break;
          }
          case 32: {
            IssueMonth = (global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for [InvoiceService.ListInvoices][google.ads.googleads.v9.services.InvoiceService.ListInvoices].
  /// </summary>
  public sealed partial class ListInvoicesResponse : pb::IMessage<ListInvoicesResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListInvoicesResponse> _parser = new pb::MessageParser<ListInvoicesResponse>(() => new ListInvoicesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListInvoicesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Services.InvoiceServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListInvoicesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListInvoicesResponse(ListInvoicesResponse other) : this() {
      invoices_ = other.invoices_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListInvoicesResponse Clone() {
      return new ListInvoicesResponse(this);
    }

    /// <summary>Field number for the "invoices" field.</summary>
    public const int InvoicesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V9.Resources.Invoice> _repeated_invoices_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V9.Resources.Invoice.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Resources.Invoice> invoices_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Resources.Invoice>();
    /// <summary>
    /// The list of invoices that match the billing setup and time period.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Resources.Invoice> Invoices {
      get { return invoices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListInvoicesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListInvoicesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!invoices_.Equals(other.invoices_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= invoices_.GetHashCode();
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
      invoices_.WriteTo(output, _repeated_invoices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      invoices_.WriteTo(ref output, _repeated_invoices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += invoices_.CalculateSize(_repeated_invoices_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListInvoicesResponse other) {
      if (other == null) {
        return;
      }
      invoices_.Add(other.invoices_);
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
          case 10: {
            invoices_.AddEntriesFrom(input, _repeated_invoices_codec);
            break;
          }
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
          case 10: {
            invoices_.AddEntriesFrom(ref input, _repeated_invoices_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
