﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Cleaning", "ByteOrderMark:The Byte Order Mark (BOM) must be removed.", Justification = "<Pending>")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>")]
[assembly: SuppressMessage("Minor Code Smell", "S1104:Fields should not have public accessibility", Justification = "<Pending>", Scope = "member", Target = "~F:MEPSortingAlgorithms.utils.Constants.generateIntoFile")]
[assembly: SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~F:MEPSortingAlgorithms.utils.Constants.generateIntoFile")]
[assembly: SuppressMessage("Minor Code Smell", "S1104:Fields should not have public accessibility", Justification = "<Pending>", Scope = "member", Target = "~F:MEPSortingAlgorithms.utils.Constants.filePath")]
[assembly: SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~F:MEPSortingAlgorithms.utils.Constants.filePath")]
[assembly: SuppressMessage("Major Code Smell", "S1118:Utility classes should not have public constructors", Justification = "<Pending>", Scope = "member", Target = "~M:MEPSortingAlgorithms.seqvential.BubbleSort.#ctor")]
[assembly: SuppressMessage("Ordering", "PostIncrement:The post-increment/decrement operator must not be used when it can be replaced with pre-increment/decrement operator.", Justification = "<Pending>", Scope = "member", Target = "~M:MEPSortingAlgorithms.seqvential.BubbleSort.BubbleSortAlgorithm(System.Int32[])")]
[assembly: SuppressMessage("Ordering", "PostIncrement:The post-increment/decrement operator must not be used when it can be replaced with pre-increment/decrement operator.", Justification = "<Pending>", Scope = "member", Target = "~M:MEPSortingAlgorithms.seqvential.BubbleSort.ReadDataFromFile(System.String)~System.Int32[]")]
[assembly: SuppressMessage("Size", "LongLine:A long line must be avoided.", Justification = "<Pending>", Scope = "member", Target = "~M:MEPSortingAlgorithms.seqvential.BubbleSort.RunBubbleSort(System.String)")]
[assembly: SuppressMessage("Ordering", "PostIncrement:The post-increment/decrement operator must not be used when it can be replaced with pre-increment/decrement operator.", Justification = "<Pending>", Scope = "member", Target = "~M:MEPSortingAlgorithms.utils.RandomGenerator.generateInputData(System.Int32,System.Int32,System.String)")]
[assembly: SuppressMessage("Size", "LongLine:A long line must be avoided.", Justification = "<Pending>", Scope = "member", Target = "~M:MEPSortingAlgorithms.utils.RandomGenerator.generateInputData(System.Int32,System.Int32,System.String)")]
[assembly: SuppressMessage("Minor Code Smell", "S2094:Classes should not be empty", Justification = "<Pending>", Scope = "type", Target = "~T:MEPSortingAlgorithms.seqvential.QuickSort")]
[assembly: SuppressMessage("Minor Code Smell", "S2094:Classes should not be empty", Justification = "<Pending>", Scope = "type", Target = "~T:MEPSortingAlgorithms.seqvential.SelectionSort")]
[assembly: SuppressMessage("Size", "LongLine:A long line must be avoided.", Justification = "<Pending>", Scope = "type", Target = "~T:MEPSortingAlgorithms.utils.Constants")]