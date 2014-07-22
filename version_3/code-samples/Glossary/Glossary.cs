﻿using System;
using System.Threading.Tasks;

using Raven.Abstractions.Data;
using Raven.Json.Linq;

namespace Raven.Documentation.CodeSamples.Glossary
{
	public class Glossary
	{
		/*
		#region bulk_insert_operation
		public class BulkInsertOperation
		{
			public delegate void BeforeEntityInsert(
				string id,
				RavenJObject data,
				RavenJObject metadata);

			public event BeforeEntityInsert OnBeforeEntityInsert = delegate { };
		
			public bool IsAborted { get { ... } }
		
			public void Abort() { ... }
		
			public Guid OperationId { get { ... } }
		
			public event Action<string> Report { ... }
		
			public void Store(object entity) { ... }
		
			public void Store(object entity, string id) { ... }
		
			public void Dispose() { ... }
		}
		#endregion
		*/

		#region bulk_insert_options
		public class BulkInsertOptions
		{
			public bool OverwriteExisting { get; set; }

			public bool CheckReferencesInIndexes { get; set; }

			public int BatchSize { get; set; }

			public int WriteTimeoutMilliseconds { get; set; }
		}
		#endregion

		#region json_document
		public class JsonDocument
		{
			public RavenJObject DataAsJson { get; set; }

			public RavenJObject Metadata { get; set; }

			public Etag Etag { get; set; }

			public string Key { get; set; }

			public DateTime? LastModified { get; set; }

			public bool? NonAuthoritativeInformation { get; set; }

			public float? TempIndexScore { get; set; }
		}
		#endregion

		#region json_document_metadata
		public class JsonDocumentMetadata
		{
			public RavenJObject Metadata { get; set; }

			public Etag Etag { get; set; }

			public string Key { get; set; }

			public DateTime? LastModified { get; set; }

			public bool? NonAuthoritativeInformation { get; set; }
		}
		#endregion

		/*
		#region operation
		public class Operation
		{
			public RavenJToken WaitForCompletion() { ... }

			public Task<RavenJToken> WaitForCompletionAsync() { ... }
		}
		#endregion
		*/
	}
}