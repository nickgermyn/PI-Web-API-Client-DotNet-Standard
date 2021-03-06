// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Linq;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API AssetDatabase controller.
	/// </summary>
	public interface IAssetDatabaseApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetDatabase</returns>
		PIAssetDatabase GetByPath(string path, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetDatabase></returns>
		ApiResponse<PIAssetDatabase> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetDatabase</returns>
		PIAssetDatabase Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetDatabase></returns>
		ApiResponse<PIAssetDatabase> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <returns>Object</returns>
		Object Update(string webId, PIAssetDatabase database);

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateWithHttpInfo(string webId, PIAssetDatabase database);

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <returns>Object</returns>
		Object Delete(string webId);

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteWithHttpInfo(string webId);

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysis</returns>
		PIItemsAnalysis FindAnalyses(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null);

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysis></returns>
		ApiResponse<PIItemsAnalysis> FindAnalysesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null);

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysisCategory</returns>
		PIItemsAnalysisCategory GetAnalysisCategories(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysisCategory></returns>
		ApiResponse<PIItemsAnalysisCategory> GetAnalysisCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateAnalysisCategory(string webId, PIAnalysisCategory analysisCategory, string webIdType = null);

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAnalysisCategoryWithHttpInfo(string webId, PIAnalysisCategory analysisCategory, string webIdType = null);

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysisTemplate</returns>
		PIItemsAnalysisTemplate GetAnalysisTemplates(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysisTemplate></returns>
		ApiResponse<PIItemsAnalysisTemplate> GetAnalysisTemplatesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateAnalysisTemplate(string webId, PIAnalysisTemplate template, string webIdType = null);

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAnalysisTemplateWithHttpInfo(string webId, PIAnalysisTemplate template, string webIdType = null);

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAttributeCategory</returns>
		PIItemsAttributeCategory GetAttributeCategories(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAttributeCategory></returns>
		ApiResponse<PIItemsAttributeCategory> GetAttributeCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateAttributeCategory(string webId, PIAttributeCategory attributeCategory, string webIdType = null);

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAttributeCategoryWithHttpInfo(string webId, PIAttributeCategory attributeCategory, string webIdType = null);

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAttribute</returns>
		PIItemsAttribute FindElementAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null);

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		ApiResponse<PIItemsAttribute> FindElementAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null);

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElementCategory</returns>
		PIItemsElementCategory GetElementCategories(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElementCategory></returns>
		ApiResponse<PIItemsElementCategory> GetElementCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateElementCategory(string webId, PIElementCategory elementCategory, string webIdType = null);

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateElementCategoryWithHttpInfo(string webId, PIElementCategory elementCategory, string webIdType = null);

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElement</returns>
		PIItemsElement GetElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		ApiResponse<PIItemsElement> GetElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateElement(string webId, PIElement element, string webIdType = null);

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateElementWithHttpInfo(string webId, PIElement element, string webIdType = null);

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElementTemplate</returns>
		PIItemsElementTemplate GetElementTemplates(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElementTemplate></returns>
		ApiResponse<PIItemsElementTemplate> GetElementTemplatesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateElementTemplate(string webId, PIElementTemplate template, string webIdType = null);

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateElementTemplateWithHttpInfo(string webId, PIElementTemplate template, string webIdType = null);

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsEnumerationSet</returns>
		PIItemsEnumerationSet GetEnumerationSets(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsEnumerationSet></returns>
		ApiResponse<PIItemsEnumerationSet> GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet, string webIdType = null);

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null);

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAttribute</returns>
		PIItemsAttribute FindEventFrameAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null);

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		ApiResponse<PIItemsAttribute> FindEventFrameAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null);

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsEventFrame</returns>
		PIItemsEventFrame GetEventFrames(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsEventFrame></returns>
		ApiResponse<PIItemsEventFrame> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateEventFrame(string webId, PIEventFrame eventFrame, string webIdType = null);

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame, string webIdType = null);

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <returns>Object</returns>
		Object Export(string webId, string endTime = null, List<string> exportMode = null, string startTime = null);

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> ExportWithHttpInfo(string webId, string endTime = null, List<string> exportMode = null, string startTime = null);

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <returns>Object</returns>
		Object Import(string webId, List<string> importMode = null);

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> ImportWithHttpInfo(string webId, List<string> importMode = null);

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElement</returns>
		PIItemsElement GetReferencedElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		ApiResponse<PIItemsElement> GetReferencedElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null);

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <returns>Object</returns>
		Object AddReferencedElement(string webId, List<string> referencedElementWebId, string referenceType = null);

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> AddReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null);

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>Object</returns>
		Object RemoveReferencedElement(string webId, List<string> referencedElementWebId);

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> RemoveReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId);

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityRights</returns>
		PIItemsSecurityRights GetSecurity(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityEntry</returns>
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null);

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PISecurityEntry</returns>
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>Object</returns>
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>Object</returns>
		Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsTableCategory</returns>
		PIItemsTableCategory GetTableCategories(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsTableCategory></returns>
		ApiResponse<PIItemsTableCategory> GetTableCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateTableCategory(string webId, PITableCategory tableCategory, string webIdType = null);

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateTableCategoryWithHttpInfo(string webId, PITableCategory tableCategory, string webIdType = null);

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsTable</returns>
		PIItemsTable GetTables(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsTable></returns>
		ApiResponse<PIItemsTable> GetTablesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateTable(string webId, PITable table, string webIdType = null);

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateTableWithHttpInfo(string webId, PITable table, string webIdType = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetDatabase></returns>
		System.Threading.Tasks.Task<PIAssetDatabase> GetByPathAsync(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetDatabase></returns>
		System.Threading.Tasks.Task<PIAssetDatabase> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIAssetDatabase database, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIAssetDatabase database, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteAsync(string webId, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysis></returns>
		System.Threading.Tasks.Task<PIItemsAnalysis> FindAnalysesAsync(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>> FindAnalysesAsyncWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysisCategory></returns>
		System.Threading.Tasks.Task<PIItemsAnalysisCategory> GetAnalysisCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisCategory>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisCategory>> GetAnalysisCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAnalysisCategoryAsync(string webId, PIAnalysisCategory analysisCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnalysisCategoryAsyncWithHttpInfo(string webId, PIAnalysisCategory analysisCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysisTemplate></returns>
		System.Threading.Tasks.Task<PIItemsAnalysisTemplate> GetAnalysisTemplatesAsync(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisTemplate>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisTemplate>> GetAnalysisTemplatesAsyncWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAnalysisTemplateAsync(string webId, PIAnalysisTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnalysisTemplateAsyncWithHttpInfo(string webId, PIAnalysisTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttributeCategory></returns>
		System.Threading.Tasks.Task<PIItemsAttributeCategory> GetAttributeCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeCategory>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeCategory>> GetAttributeCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAttributeCategoryAsync(string webId, PIAttributeCategory attributeCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAttributeCategoryAsyncWithHttpInfo(string webId, PIAttributeCategory attributeCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		System.Threading.Tasks.Task<PIItemsAttribute> FindElementAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindElementAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementCategory></returns>
		System.Threading.Tasks.Task<PIItemsElementCategory> GetElementCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>> GetElementCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateElementCategoryAsync(string webId, PIElementCategory elementCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementCategoryAsyncWithHttpInfo(string webId, PIElementCategory elementCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		System.Threading.Tasks.Task<PIItemsElement> GetElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateElementAsync(string webId, PIElement element, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementAsyncWithHttpInfo(string webId, PIElement element, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementTemplate></returns>
		System.Threading.Tasks.Task<PIItemsElementTemplate> GetElementTemplatesAsync(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementTemplate>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElementTemplate>> GetElementTemplatesAsyncWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateElementTemplateAsync(string webId, PIElementTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementTemplateAsyncWithHttpInfo(string webId, PIElementTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEnumerationSet></returns>
		System.Threading.Tasks.Task<PIItemsEnumerationSet> GetEnumerationSetsAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEnumerationSet>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsEnumerationSet>> GetEnumerationSetsAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateEnumerationSetAsync(string webId, PIEnumerationSet enumerationSet, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateEnumerationSetAsyncWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		System.Threading.Tasks.Task<PIItemsAttribute> FindEventFrameAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindEventFrameAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEventFrame></returns>
		System.Threading.Tasks.Task<PIItemsEventFrame> GetEventFramesAsync(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>> GetEventFramesAsyncWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateEventFrameAsync(string webId, PIEventFrame eventFrame, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateEventFrameAsyncWithHttpInfo(string webId, PIEventFrame eventFrame, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> ExportAsync(string webId, string endTime = null, List<string> exportMode = null, string startTime = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> ExportAsyncWithHttpInfo(string webId, string endTime = null, List<string> exportMode = null, string startTime = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> ImportAsync(string webId, List<string> importMode = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> ImportAsyncWithHttpInfo(string webId, List<string> importMode = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		System.Threading.Tasks.Task<PIItemsElement> GetReferencedElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetReferencedElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> AddReferencedElementAsync(string webId, List<string> referencedElementWebId, string referenceType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> AddReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> RemoveReferencedElementAsync(string webId, List<string> referencedElementWebId, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsTableCategory></returns>
		System.Threading.Tasks.Task<PIItemsTableCategory> GetTableCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsTableCategory>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsTableCategory>> GetTableCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateTableCategoryAsync(string webId, PITableCategory tableCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateTableCategoryAsyncWithHttpInfo(string webId, PITableCategory tableCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsTable></returns>
		System.Threading.Tasks.Task<PIItemsTable> GetTablesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsTable>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsTable>> GetTablesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateTableAsync(string webId, PITable table, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateTableAsyncWithHttpInfo(string webId, PITable table, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		#endregion
	}

	public class AssetDatabaseApi : IAssetDatabaseApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AssetDatabaseApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetDatabase</returns>
		public PIAssetDatabase GetByPath(string path, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIAssetDatabase> localVarResponse = GetByPathWithHttpInfo(path, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetDatabase></returns>
		public ApiResponse<PIAssetDatabase> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (path!= null) localVarQueryParams.Add("path", path, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetDatabase>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetDatabase)));
		}

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetDatabase</returns>
		public PIAssetDatabase Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIAssetDatabase> localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetDatabase></returns>
		public ApiResponse<PIAssetDatabase> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetDatabase>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetDatabase)));
		}

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <returns>Object</returns>
		public Object Update(string webId, PIAssetDatabase database)
		{
			ApiResponse<Object> localVarResponse = UpdateWithHttpInfo(webId, database);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateWithHttpInfo(string webId, PIAssetDatabase database)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'database' is set
			if (database == null)
				throw new ApiException(400, "Missing required parameter 'database'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(database);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("PATCH"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <returns>Object</returns>
		public Object Delete(string webId)
		{
			ApiResponse<Object> localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysis</returns>
		public PIItemsAnalysis FindAnalyses(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null)
		{
			ApiResponse<PIItemsAnalysis> localVarResponse = FindAnalysesWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, startIndex, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysis></returns>
		public ApiResponse<PIItemsAnalysis> FindAnalysesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'field' is set
			if (field == null)
				throw new ApiException(400, "Missing required parameter 'field'");

			var localVarPath = "/assetdatabases/{webId}/analyses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, true);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindAnalysesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysis>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysis)));
		}

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysisCategory</returns>
		public PIItemsAnalysisCategory GetAnalysisCategories(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsAnalysisCategory> localVarResponse = GetAnalysisCategoriesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysisCategory></returns>
		public ApiResponse<PIItemsAnalysisCategory> GetAnalysisCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/analysiscategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisCategoriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysisCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysisCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisCategory)));
		}

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateAnalysisCategory(string webId, PIAnalysisCategory analysisCategory, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateAnalysisCategoryWithHttpInfo(webId, analysisCategory, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAnalysisCategoryWithHttpInfo(string webId, PIAnalysisCategory analysisCategory, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'analysisCategory' is set
			if (analysisCategory == null)
				throw new ApiException(400, "Missing required parameter 'analysisCategory'");

			var localVarPath = "/assetdatabases/{webId}/analysiscategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(analysisCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisCategoryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysisTemplate</returns>
		public PIItemsAnalysisTemplate GetAnalysisTemplates(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			ApiResponse<PIItemsAnalysisTemplate> localVarResponse = GetAnalysisTemplatesWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysisTemplate></returns>
		public ApiResponse<PIItemsAnalysisTemplate> GetAnalysisTemplatesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'field' is set
			if (field == null)
				throw new ApiException(400, "Missing required parameter 'field'");

			var localVarPath = "/assetdatabases/{webId}/analysistemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, true);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisTemplatesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysisTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysisTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisTemplate)));
		}

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateAnalysisTemplate(string webId, PIAnalysisTemplate template, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateAnalysisTemplateWithHttpInfo(webId, template, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAnalysisTemplateWithHttpInfo(string webId, PIAnalysisTemplate template, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'template' is set
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/assetdatabases/{webId}/analysistemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(template);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisTemplateWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAttributeCategory</returns>
		public PIItemsAttributeCategory GetAttributeCategories(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsAttributeCategory> localVarResponse = GetAttributeCategoriesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAttributeCategory></returns>
		public ApiResponse<PIItemsAttributeCategory> GetAttributeCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/attributecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributeCategoriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttributeCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttributeCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeCategory)));
		}

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateAttributeCategory(string webId, PIAttributeCategory attributeCategory, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateAttributeCategoryWithHttpInfo(webId, attributeCategory, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAttributeCategoryWithHttpInfo(string webId, PIAttributeCategory attributeCategory, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'attributeCategory' is set
			if (attributeCategory == null)
				throw new ApiException(400, "Missing required parameter 'attributeCategory'");

			var localVarPath = "/assetdatabases/{webId}/attributecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(attributeCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttributeCategoryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAttribute</returns>
		public PIItemsAttribute FindElementAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = FindElementAttributesWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, elementCategory, elementDescriptionFilter, elementNameFilter, elementTemplate, elementType, maxCount, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		public ApiResponse<PIItemsAttribute> FindElementAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementattributes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", attributeCategory, false);
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", attributeDescriptionFilter, false);
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", attributeNameFilter, false);
			if (attributeType!= null) localVarQueryParams.Add("attributeType", attributeType, false);
			if (elementCategory!= null) localVarQueryParams.Add("elementCategory", elementCategory, false);
			if (elementDescriptionFilter!= null) localVarQueryParams.Add("elementDescriptionFilter", elementDescriptionFilter, false);
			if (elementNameFilter!= null) localVarQueryParams.Add("elementNameFilter", elementNameFilter, false);
			if (elementTemplate!= null) localVarQueryParams.Add("elementTemplate", elementTemplate, false);
			if (elementType!= null) localVarQueryParams.Add("elementType", elementType, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindElementAttributesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElementCategory</returns>
		public PIItemsElementCategory GetElementCategories(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsElementCategory> localVarResponse = GetElementCategoriesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElementCategory></returns>
		public ApiResponse<PIItemsElementCategory> GetElementCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementcategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementCategoriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElementCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElementCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementCategory)));
		}

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateElementCategory(string webId, PIElementCategory elementCategory, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateElementCategoryWithHttpInfo(webId, elementCategory, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateElementCategoryWithHttpInfo(string webId, PIElementCategory elementCategory, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'elementCategory' is set
			if (elementCategory == null)
				throw new ApiException(400, "Missing required parameter 'elementCategory'");

			var localVarPath = "/assetdatabases/{webId}/elementcategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(elementCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementCategoryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElement</returns>
		public PIItemsElement GetElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = GetElementsWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex, templateName, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		public ApiResponse<PIItemsElement> GetElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", descriptionFilter, false);
			if (elementType!= null) localVarQueryParams.Add("elementType", elementType, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateElement(string webId, PIElement element, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateElementWithHttpInfo(webId, element, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateElementWithHttpInfo(string webId, PIElement element, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'element' is set
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/assetdatabases/{webId}/elements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(element);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElementTemplate</returns>
		public PIItemsElementTemplate GetElementTemplates(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			ApiResponse<PIItemsElementTemplate> localVarResponse = GetElementTemplatesWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElementTemplate></returns>
		public ApiResponse<PIItemsElementTemplate> GetElementTemplatesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'field' is set
			if (field == null)
				throw new ApiException(400, "Missing required parameter 'field'");

			var localVarPath = "/assetdatabases/{webId}/elementtemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, true);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementTemplatesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElementTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementTemplate)));
		}

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateElementTemplate(string webId, PIElementTemplate template, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateElementTemplateWithHttpInfo(webId, template, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateElementTemplateWithHttpInfo(string webId, PIElementTemplate template, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'template' is set
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/assetdatabases/{webId}/elementtemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(template);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementTemplateWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsEnumerationSet</returns>
		public PIItemsEnumerationSet GetEnumerationSets(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsEnumerationSet> localVarResponse = GetEnumerationSetsWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsEnumerationSet></returns>
		public ApiResponse<PIItemsEnumerationSet> GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/enumerationsets";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEnumerationSetsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsEnumerationSet>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsEnumerationSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEnumerationSet)));
		}

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateEnumerationSetWithHttpInfo(webId, enumerationSet, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'enumerationSet' is set
			if (enumerationSet == null)
				throw new ApiException(400, "Missing required parameter 'enumerationSet'");

			var localVarPath = "/assetdatabases/{webId}/enumerationsets";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(enumerationSet);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEnumerationSetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAttribute</returns>
		public PIItemsAttribute FindEventFrameAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = FindEventFrameAttributesWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, endTime, eventFrameCategory, eventFrameDescriptionFilter, eventFrameNameFilter, eventFrameTemplate, maxCount, referencedElementNameFilter, searchFullHierarchy, searchMode, selectedFields, sortField, sortOrder, startIndex, startTime, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		public ApiResponse<PIItemsAttribute> FindEventFrameAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/eventframeattributes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", attributeCategory, false);
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", attributeDescriptionFilter, false);
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", attributeNameFilter, false);
			if (attributeType!= null) localVarQueryParams.Add("attributeType", attributeType, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (eventFrameCategory!= null) localVarQueryParams.Add("eventFrameCategory", eventFrameCategory, false);
			if (eventFrameDescriptionFilter!= null) localVarQueryParams.Add("eventFrameDescriptionFilter", eventFrameDescriptionFilter, false);
			if (eventFrameNameFilter!= null) localVarQueryParams.Add("eventFrameNameFilter", eventFrameNameFilter, false);
			if (eventFrameTemplate!= null) localVarQueryParams.Add("eventFrameTemplate", eventFrameTemplate, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", referencedElementNameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (searchMode!= null) localVarQueryParams.Add("searchMode", searchMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindEventFrameAttributesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsEventFrame</returns>
		public PIItemsEventFrame GetEventFrames(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null)
		{
			ApiResponse<PIItemsEventFrame> localVarResponse = GetEventFramesWithHttpInfo(webId, canBeAcknowledged, categoryName, endTime, isAcknowledged, maxCount, nameFilter, referencedElementNameFilter, referencedElementTemplateName, searchFullHierarchy, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime, templateName, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsEventFrame></returns>
		public ApiResponse<PIItemsEventFrame> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/eventframes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (canBeAcknowledged!= null) localVarQueryParams.Add("canBeAcknowledged", canBeAcknowledged, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (isAcknowledged!= null) localVarQueryParams.Add("isAcknowledged", isAcknowledged, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", referencedElementNameFilter, false);
			if (referencedElementTemplateName!= null) localVarQueryParams.Add("referencedElementTemplateName", referencedElementTemplateName, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (searchMode!= null) localVarQueryParams.Add("searchMode", searchMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (severity!= null) localVarQueryParams.Add("severity", severity, true);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEventFramesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsEventFrame>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEventFrame)));
		}

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateEventFrame(string webId, PIEventFrame eventFrame, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateEventFrameWithHttpInfo(webId, eventFrame, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'eventFrame' is set
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/assetdatabases/{webId}/eventframes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEventFrameWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <returns>Object</returns>
		public Object Export(string webId, string endTime = null, List<string> exportMode = null, string startTime = null)
		{
			ApiResponse<Object> localVarResponse = ExportWithHttpInfo(webId, endTime, exportMode, startTime);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> ExportWithHttpInfo(string webId, string endTime = null, List<string> exportMode = null, string startTime = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/export";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (exportMode!= null) localVarQueryParams.Add("exportMode", exportMode, true);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ExportWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <returns>Object</returns>
		public Object Import(string webId, List<string> importMode = null)
		{
			ApiResponse<Object> localVarResponse = ImportWithHttpInfo(webId, importMode);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> ImportWithHttpInfo(string webId, List<string> importMode = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/import";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (importMode!= null) localVarQueryParams.Add("importMode", importMode, true);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ImportWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsElement</returns>
		public PIItemsElement GetReferencedElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = GetReferencedElementsWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, selectedFields, sortField, sortOrder, startIndex, templateName, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		public ApiResponse<PIItemsElement> GetReferencedElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", descriptionFilter, false);
			if (elementType!= null) localVarQueryParams.Add("elementType", elementType, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetReferencedElementsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <returns>Object</returns>
		public Object AddReferencedElement(string webId, List<string> referencedElementWebId, string referenceType = null)
		{
			ApiResponse<Object> localVarResponse = AddReferencedElementWithHttpInfo(webId, referencedElementWebId, referenceType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> AddReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", referencedElementWebId, true);
			if (referenceType!= null) localVarQueryParams.Add("referenceType", referenceType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AddReferencedElementWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>Object</returns>
		public Object RemoveReferencedElement(string webId, List<string> referencedElementWebId)
		{
			ApiResponse<Object> localVarResponse = RemoveReferencedElementWithHttpInfo(webId, referencedElementWebId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> RemoveReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", referencedElementWebId, true);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("RemoveReferencedElementWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityRights</returns>
		public PIItemsSecurityRights GetSecurity(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityRights> localVarResponse = GetSecurityWithHttpInfo(webId, securityItem, userIdentity, forceRefresh, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		public ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityItem' is set
			if (securityItem == null)
				throw new ApiException(400, "Missing required parameter 'securityItem'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetdatabases/{webId}/security";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, true);
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", userIdentity, true);
			if (forceRefresh!= null) localVarQueryParams.Add("forceRefresh", forceRefresh, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityRights>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityEntry</returns>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, securityItem, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		public ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren, securityItem, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetdatabases/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PISecurityEntry</returns>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PISecurityEntry> localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, securityItem, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		public ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByNameWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>Object</returns>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)
		{
			ApiResponse<Object> localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("PUT"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>Object</returns>
		public Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null, string securityItem = null)
		{
			ApiResponse<Object> localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsTableCategory</returns>
		public PIItemsTableCategory GetTableCategories(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsTableCategory> localVarResponse = GetTableCategoriesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsTableCategory></returns>
		public ApiResponse<PIItemsTableCategory> GetTableCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/tablecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTableCategoriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsTableCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsTableCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTableCategory)));
		}

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateTableCategory(string webId, PITableCategory tableCategory, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateTableCategoryWithHttpInfo(webId, tableCategory, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateTableCategoryWithHttpInfo(string webId, PITableCategory tableCategory, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'tableCategory' is set
			if (tableCategory == null)
				throw new ApiException(400, "Missing required parameter 'tableCategory'");

			var localVarPath = "/assetdatabases/{webId}/tablecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(tableCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateTableCategoryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsTable</returns>
		public PIItemsTable GetTables(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsTable> localVarResponse = GetTablesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsTable></returns>
		public ApiResponse<PIItemsTable> GetTablesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/tables";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTablesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsTable>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsTable)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTable)));
		}

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateTable(string webId, PITable table, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateTableWithHttpInfo(webId, table, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateTableWithHttpInfo(string webId, PITable table, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'table' is set
			if (table == null)
				throw new ApiException(400, "Missing required parameter 'table'");

			var localVarPath = "/assetdatabases/{webId}/tables";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(table);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateTableWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetDatabase></returns>
		public async System.Threading.Tasks.Task<PIAssetDatabase> GetByPathAsync(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIAssetDatabase> localVarResponse = await GetByPathAsyncWithHttpInfo(path, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Database by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset database based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (path!= null) localVarQueryParams.Add("path", path, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetDatabase>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetDatabase)));
		}

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetDatabase></returns>
		public async System.Threading.Tasks.Task<PIAssetDatabase> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIAssetDatabase> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAssetDatabase>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetDatabase>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetDatabase)));
		}

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIAssetDatabase database, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await UpdateAsyncWithHttpInfo(webId, database, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an asset database by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="database">A partial database containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIAssetDatabase database, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'database' is set
			if (database == null)
				throw new ApiException(400, "Missing required parameter 'database'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(database);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("PATCH"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteAsync(string webId, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await DeleteAsyncWithHttpInfo(webId, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysis></returns>
		public async System.Threading.Tasks.Task<PIItemsAnalysis> FindAnalysesAsync(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAnalysis> localVarResponse = await FindAnalysesAsyncWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, startIndex, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search for the analyses.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding analyses. The default is null.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>> FindAnalysesAsyncWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'field' is set
			if (field == null)
				throw new ApiException(400, "Missing required parameter 'field'");

			var localVarPath = "/assetdatabases/{webId}/analyses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, true);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindAnalysesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysis>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysis)));
		}

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysisCategory></returns>
		public async System.Threading.Tasks.Task<PIItemsAnalysisCategory> GetAnalysisCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAnalysisCategory> localVarResponse = await GetAnalysisCategoriesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analysis categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisCategory>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisCategory>> GetAnalysisCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/analysiscategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisCategoriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysisCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysisCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisCategory)));
		}

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAnalysisCategoryAsync(string webId, PIAnalysisCategory analysisCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateAnalysisCategoryAsyncWithHttpInfo(webId, analysisCategory, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an analysis category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis category.</param>
		/// <param name="analysisCategory">The new analysis category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnalysisCategoryAsyncWithHttpInfo(string webId, PIAnalysisCategory analysisCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'analysisCategory' is set
			if (analysisCategory == null)
				throw new ApiException(400, "Missing required parameter 'analysisCategory'");

			var localVarPath = "/assetdatabases/{webId}/analysiscategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(analysisCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisCategoryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysisTemplate></returns>
		public async System.Threading.Tasks.Task<PIItemsAnalysisTemplate> GetAnalysisTemplatesAsync(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAnalysisTemplate> localVarResponse = await GetAnalysisTemplatesAsyncWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the analysis templates based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisTemplate>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisTemplate>> GetAnalysisTemplatesAsyncWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'field' is set
			if (field == null)
				throw new ApiException(400, "Missing required parameter 'field'");

			var localVarPath = "/assetdatabases/{webId}/analysistemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, true);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisTemplatesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysisTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysisTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisTemplate)));
		}

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAnalysisTemplateAsync(string webId, PIAnalysisTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateAnalysisTemplateAsyncWithHttpInfo(webId, template, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an analysis template at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// Analyses that are based on an analysis template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the analysis template.</param>
		/// <param name="template">The new analysis template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnalysisTemplateAsyncWithHttpInfo(string webId, PIAnalysisTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'template' is set
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/assetdatabases/{webId}/analysistemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(template);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisTemplateAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttributeCategory></returns>
		public async System.Threading.Tasks.Task<PIItemsAttributeCategory> GetAttributeCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAttributeCategory> localVarResponse = await GetAttributeCategoriesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve attribute categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeCategory>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeCategory>> GetAttributeCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/attributecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributeCategoriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttributeCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttributeCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeCategory)));
		}

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAttributeCategoryAsync(string webId, PIAttributeCategory attributeCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateAttributeCategoryAsyncWithHttpInfo(webId, attributeCategory, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an attribute category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the attribute category.</param>
		/// <param name="attributeCategory">The new attribute category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAttributeCategoryAsyncWithHttpInfo(string webId, PIAttributeCategory attributeCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'attributeCategory' is set
			if (attributeCategory == null)
				throw new ApiException(400, "Missing required parameter 'attributeCategory'");

			var localVarPath = "/assetdatabases/{webId}/attributecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(attributeCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttributeCategoryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		public async System.Threading.Tasks.Task<PIItemsAttribute> FindElementAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAttribute> localVarResponse = await FindElementAttributesAsyncWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, elementCategory, elementDescriptionFilter, elementNameFilter, elementTemplate, elementType, maxCount, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindElementAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementattributes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", attributeCategory, false);
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", attributeDescriptionFilter, false);
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", attributeNameFilter, false);
			if (attributeType!= null) localVarQueryParams.Add("attributeType", attributeType, false);
			if (elementCategory!= null) localVarQueryParams.Add("elementCategory", elementCategory, false);
			if (elementDescriptionFilter!= null) localVarQueryParams.Add("elementDescriptionFilter", elementDescriptionFilter, false);
			if (elementNameFilter!= null) localVarQueryParams.Add("elementNameFilter", elementNameFilter, false);
			if (elementTemplate!= null) localVarQueryParams.Add("elementTemplate", elementTemplate, false);
			if (elementType!= null) localVarQueryParams.Add("elementType", elementType, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindElementAttributesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementCategory></returns>
		public async System.Threading.Tasks.Task<PIItemsElementCategory> GetElementCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsElementCategory> localVarResponse = await GetElementCategoriesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve element categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>> GetElementCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementcategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementCategoriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElementCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElementCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementCategory)));
		}

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateElementCategoryAsync(string webId, PIElementCategory elementCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateElementCategoryAsyncWithHttpInfo(webId, elementCategory, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an element category at the Asset Database root.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element category.</param>
		/// <param name="elementCategory">The new element category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementCategoryAsyncWithHttpInfo(string webId, PIElementCategory elementCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'elementCategory' is set
			if (elementCategory == null)
				throw new ApiException(400, "Missing required parameter 'elementCategory'");

			var localVarPath = "/assetdatabases/{webId}/elementcategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(elementCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementCategoryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		public async System.Threading.Tasks.Task<PIItemsElement> GetElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsElement> localVarResponse = await GetElementsAsyncWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex, templateName, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", descriptionFilter, false);
			if (elementType!= null) localVarQueryParams.Add("elementType", elementType, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateElementAsync(string webId, PIElement element, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateElementAsyncWithHttpInfo(webId, element, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementAsyncWithHttpInfo(string webId, PIElement element, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'element' is set
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/assetdatabases/{webId}/elements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(element);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementTemplate></returns>
		public async System.Threading.Tasks.Task<PIItemsElementTemplate> GetElementTemplatesAsync(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsElementTemplate> localVarResponse = await GetElementTemplatesAsyncWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
		/// </summary>
		/// <remarks>
		/// Users can search for the element and event frame template based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the templates that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementTemplate>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElementTemplate>> GetElementTemplatesAsyncWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'field' is set
			if (field == null)
				throw new ApiException(400, "Missing required parameter 'field'");

			var localVarPath = "/assetdatabases/{webId}/elementtemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, true);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementTemplatesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElementTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementTemplate)));
		}

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateElementTemplateAsync(string webId, PIElementTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateElementTemplateAsyncWithHttpInfo(webId, template, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
		/// </summary>
		/// <remarks>
		/// Elements and event frames that are based on an element template will inherit characteristics defined in the template.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the element template.</param>
		/// <param name="template">The new element template definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementTemplateAsyncWithHttpInfo(string webId, PIElementTemplate template, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'template' is set
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/assetdatabases/{webId}/elementtemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(template);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementTemplateAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEnumerationSet></returns>
		public async System.Threading.Tasks.Task<PIItemsEnumerationSet> GetEnumerationSetsAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsEnumerationSet> localVarResponse = await GetEnumerationSetsAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve enumeration sets for given asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEnumerationSet>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsEnumerationSet>> GetEnumerationSetsAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/enumerationsets";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEnumerationSetsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsEnumerationSet>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsEnumerationSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEnumerationSet)));
		}

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateEnumerationSetAsync(string webId, PIEnumerationSet enumerationSet, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateEnumerationSetAsyncWithHttpInfo(webId, enumerationSet, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an enumeration set at the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the enumeration set.</param>
		/// <param name="enumerationSet">The new enumeration set definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateEnumerationSetAsyncWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'enumerationSet' is set
			if (enumerationSet == null)
				throw new ApiException(400, "Missing required parameter 'enumerationSet'");

			var localVarPath = "/assetdatabases/{webId}/enumerationsets";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(enumerationSet);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEnumerationSetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		public async System.Threading.Tasks.Task<PIItemsAttribute> FindEventFrameAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAttribute> localVarResponse = await FindEventFrameAttributesAsyncWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, endTime, eventFrameCategory, eventFrameDescriptionFilter, eventFrameNameFilter, eventFrameTemplate, maxCount, referencedElementNameFilter, searchFullHierarchy, searchMode, selectedFields, sortField, sortOrder, startIndex, startTime, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindEventFrameAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/eventframeattributes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", attributeCategory, false);
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", attributeDescriptionFilter, false);
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", attributeNameFilter, false);
			if (attributeType!= null) localVarQueryParams.Add("attributeType", attributeType, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (eventFrameCategory!= null) localVarQueryParams.Add("eventFrameCategory", eventFrameCategory, false);
			if (eventFrameDescriptionFilter!= null) localVarQueryParams.Add("eventFrameDescriptionFilter", eventFrameDescriptionFilter, false);
			if (eventFrameNameFilter!= null) localVarQueryParams.Add("eventFrameNameFilter", eventFrameNameFilter, false);
			if (eventFrameTemplate!= null) localVarQueryParams.Add("eventFrameTemplate", eventFrameTemplate, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", referencedElementNameFilter, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (searchMode!= null) localVarQueryParams.Add("searchMode", searchMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindEventFrameAttributesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEventFrame></returns>
		public async System.Threading.Tasks.Task<PIItemsEventFrame> GetEventFramesAsync(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsEventFrame> localVarResponse = await GetEventFramesAsyncWithHttpInfo(webId, canBeAcknowledged, categoryName, endTime, isAcknowledged, maxCount, nameFilter, referencedElementNameFilter, referencedElementTemplateName, searchFullHierarchy, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime, templateName, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource that have been active in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>> GetEventFramesAsyncWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/eventframes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (canBeAcknowledged!= null) localVarQueryParams.Add("canBeAcknowledged", canBeAcknowledged, false);
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (isAcknowledged!= null) localVarQueryParams.Add("isAcknowledged", isAcknowledged, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", referencedElementNameFilter, false);
			if (referencedElementTemplateName!= null) localVarQueryParams.Add("referencedElementTemplateName", referencedElementTemplateName, false);
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", searchFullHierarchy, false);
			if (searchMode!= null) localVarQueryParams.Add("searchMode", searchMode, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (severity!= null) localVarQueryParams.Add("severity", severity, true);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEventFramesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsEventFrame>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEventFrame)));
		}

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateEventFrameAsync(string webId, PIEventFrame eventFrame, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateEventFrameAsyncWithHttpInfo(webId, eventFrame, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateEventFrameAsyncWithHttpInfo(string webId, PIEventFrame eventFrame, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'eventFrame' is set
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/assetdatabases/{webId}/eventframes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEventFrameAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> ExportAsync(string webId, string endTime = null, List<string> exportMode = null, string startTime = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await ExportAsyncWithHttpInfo(webId, endTime, exportMode, startTime, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Export the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.</param>
		/// <param name="exportMode">Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.</param>
		/// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> ExportAsyncWithHttpInfo(string webId, string endTime = null, List<string> exportMode = null, string startTime = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/export";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (exportMode!= null) localVarQueryParams.Add("exportMode", exportMode, true);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ExportAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> ImportAsync(string webId, List<string> importMode = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await ImportAsyncWithHttpInfo(webId, importMode, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Import an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="importMode">Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> ImportAsyncWithHttpInfo(string webId, List<string> importMode = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/import";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (importMode!= null) localVarQueryParams.Add("importMode", importMode, true);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ImportAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		public async System.Threading.Tasks.Task<PIItemsElement> GetReferencedElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsElement> localVarResponse = await GetReferencedElementsAsyncWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, selectedFields, sortField, sortOrder, startIndex, templateName, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetReferencedElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", categoryName, false);
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", descriptionFilter, false);
			if (elementType!= null) localVarQueryParams.Add("elementType", elementType, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (templateName!= null) localVarQueryParams.Add("templateName", templateName, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetReferencedElementsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> AddReferencedElementAsync(string webId, List<string> referencedElementWebId, string referenceType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await AddReferencedElementAsyncWithHttpInfo(webId, referencedElementWebId, referenceType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Add a reference to an existing element to the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", referencedElementWebId, true);
			if (referenceType!= null) localVarQueryParams.Add("referenceType", referenceType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AddReferencedElementAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> RemoveReferencedElementAsync(string webId, List<string> referencedElementWebId, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await RemoveReferencedElementAsyncWithHttpInfo(webId, referencedElementWebId, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Remove a reference to an existing element from the specified database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", referencedElementWebId, true);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("RemoveReferencedElementAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityRights> localVarResponse = await GetSecurityAsyncWithHttpInfo(webId, securityItem, userIdentity, forceRefresh, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset database for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityItem' is set
			if (securityItem == null)
				throw new ApiException(400, "Missing required parameter 'securityItem'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetdatabases/{webId}/security";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, true);
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", userIdentity, true);
			if (forceRefresh!= null) localVarQueryParams.Add("forceRefresh", forceRefresh, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityRights>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = await GetSecurityEntriesAsyncWithHttpInfo(webId, nameFilter, securityItem, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateSecurityEntryAsyncWithHttpInfo(webId, securityEntry, applyToChildren, securityItem, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset database where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetdatabases/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		public async System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PISecurityEntry> localVarResponse = await GetSecurityEntryByNameAsyncWithHttpInfo(name, webId, securityItem, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset database with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByNameAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await UpdateSecurityEntryAsyncWithHttpInfo(name, webId, securityEntry, applyToChildren, securityItem, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("PUT"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await DeleteSecurityEntryAsyncWithHttpInfo(name, webId, applyToChildren, securityItem, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset database where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsTableCategory></returns>
		public async System.Threading.Tasks.Task<PIItemsTableCategory> GetTableCategoriesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsTableCategory> localVarResponse = await GetTableCategoriesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve table categories for a given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsTableCategory>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsTableCategory>> GetTableCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/tablecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTableCategoriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsTableCategory>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsTableCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTableCategory)));
		}

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateTableCategoryAsync(string webId, PITableCategory tableCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateTableCategoryAsyncWithHttpInfo(webId, tableCategory, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a table category on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table category.</param>
		/// <param name="tableCategory">The new table category definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateTableCategoryAsyncWithHttpInfo(string webId, PITableCategory tableCategory, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'tableCategory' is set
			if (tableCategory == null)
				throw new ApiException(400, "Missing required parameter 'tableCategory'");

			var localVarPath = "/assetdatabases/{webId}/tablecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(tableCategory);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateTableCategoryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsTable></returns>
		public async System.Threading.Tasks.Task<PIItemsTable> GetTablesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsTable> localVarResponse = await GetTablesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve tables for given Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsTable>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsTable>> GetTablesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/tables";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTablesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsTable>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsTable)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTable)));
		}

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateTableAsync(string webId, PITable table, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateTableAsyncWithHttpInfo(webId, table, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a table on the Asset Database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the database in which to create the table.</param>
		/// <param name="table">The new table definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateTableAsyncWithHttpInfo(string webId, PITable table, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'table' is set
			if (table == null)
				throw new ApiException(400, "Missing required parameter 'table'");

			var localVarPath = "/assetdatabases/{webId}/tables";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(table);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateTableAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
	}
}
