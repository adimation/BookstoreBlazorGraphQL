using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

public class GraphQLService
{
    private readonly GraphQLHttpClient _client;

    public GraphQLService()
    {
        _client = new GraphQLHttpClient("https://localhost:5001/graphql", new NewtonsoftJsonSerializer());
    }

    public async Task<GraphQLResponse<T>> SendQueryAsync<T>(GraphQLRequest query)
    {
        return await _client.SendQueryAsync<T>(query);
    }

    public async Task<GraphQLResponse<T>> SendMutationAsync<T>(GraphQLRequest mutation)
    {
        return await _client.SendMutationAsync<T>(mutation);
    }
}