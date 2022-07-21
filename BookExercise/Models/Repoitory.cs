using System.Collections.Generic;

namespace BookExercise.Models
{
    public static class Repoitory
    {
       
            private static List<GuestResponse> responses=new List<GuestResponse>();
            public static IEnumerable<GuestResponse> Responses
            {
                get { 
                    return responses;
                }
            }
            public static void AddResponse(GuestResponse response)
            {
                responses.Add(response);
            }   
  
    }
}
