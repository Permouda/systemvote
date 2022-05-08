using System;
using System.Collections.Generic;
using systemvote.Models;
namespace systemvote.services

{

    public static class VoteServices
    {
    static List<Vote> votes { get; }
    static int nextId = 3;
    static VoteServices()
    {
        votes = new List<Vote>
        {
            new Vote (1,1,new DateTime(2022,5,7)),
            new Vote (2,2,new DateTime(2022,6,6)),
            
        };
    }
    public static List<Vote> GetAll() => votes;
        
    
    public static Vote? Get(int id)
    {
        foreach(Vote v in votes)
        {
            if(v.id == id)
            {
                return v;
            }
            
        }
        return null;
    }

    public static void Add(Vote vote)
    {
        vote.id = nextId++;
        votes.Add(vote);
    }

    public static void Delete(int id)
    {
        var vote = Get(id);
        if(vote is null)
            return;

        votes.Remove(vote);
    }

    public static void Update(Vote vote)
    {
        var index = votes.FindIndex(v => v.id == vote.id);
        if(index == -1)
            return;

        votes[index] = vote;
    }

    }
}