using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GetEmotionListResponse")]
	[Serializable]
	public class GetEmotionListResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private SKBuiltinBuffer_t _ReqBuf;

		private uint _EmotionCount;

		private readonly List<EmotionSummary> _EmotionList = new List<EmotionSummary>();

		private EmotionBanner _Banner = null;

		private uint _NewBannerCount = 0u;

		private readonly List<EmotionBanner> _NewBannerList = new List<EmotionBanner>();

		private uint _CellCount = 0u;

		private readonly List<EmotionCell> _CellList = new List<EmotionCell>();

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "ReqBuf", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t ReqBuf
		{
			get
			{
				return this._ReqBuf;
			}
			set
			{
				this._ReqBuf = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "EmotionCount", DataFormat = DataFormat.TwosComplement)]
		public uint EmotionCount
		{
			get
			{
				return this._EmotionCount;
			}
			set
			{
				this._EmotionCount = value;
			}
		}

		[ProtoMember(4, Name = "EmotionList", DataFormat = DataFormat.Default)]
		public List<EmotionSummary> EmotionList
		{
			get
			{
				return this._EmotionList;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "Banner", DataFormat = DataFormat.Default), DefaultValue(null)]
		public EmotionBanner Banner
		{
			get
			{
				return this._Banner;
			}
			set
			{
				this._Banner = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "NewBannerCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint NewBannerCount
		{
			get
			{
				return this._NewBannerCount;
			}
			set
			{
				this._NewBannerCount = value;
			}
		}

		[ProtoMember(7, Name = "NewBannerList", DataFormat = DataFormat.Default)]
		public List<EmotionBanner> NewBannerList
		{
			get
			{
				return this._NewBannerList;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "CellCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint CellCount
		{
			get
			{
				return this._CellCount;
			}
			set
			{
				this._CellCount = value;
			}
		}

		[ProtoMember(9, Name = "CellList", DataFormat = DataFormat.Default)]
		public List<EmotionCell> CellList
		{
			get
			{
				return this._CellList;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
