//using system.collections.generic;
//using system.linq;
//using system.web.mvc;
//using f2018travel.models;

//namespace f2018travel.controllers.api
//{
//    [system.web.mvc.route("api/[destinations]")]
//    [apicontroller]
//    public class destination1controller : controller
//    {
//        private object db;

//        // get: destination1
       
//        [httpget]
//        public ienumerable<destination> get()
//        {
//            return db.destinations.orderby(a => a.name);
//        }

//        [httpget("{id}")]
//        public actionresult get(int id)
//        {
//            destination team = db.destinations.singleordefault(a => a.destinationid == id);

//            if (team == null)
//            {
//                return notfound();
//            }
//            return ok(team);
//        }

//        // post: api/teams
//        [httppost]
//        public actionresult post([frombody] destination destination)
//        {
//            if (!modelstate.isvalid)
//            {
//                return badrequest(modelstate);
//            }

//            db.destinations.add(destination);
//            db.savechanges();
//            return createdataction("post", new { id = destination.destinationid });
//        }

//        // put: api/teams/5
//        [httpput("{id}")]
//        public actionresult put(int id, [frombody] destination destination)
//        {

//            if (!modelstate.isvalid)
//            {
//                return badrequest(modelstate);
//            }

//            db.entry(destination).state = microsoft.entityframeworkcore.entitystate.modified;
//            db.savechanges();
//            return acceptedataction("put", destination);
//        }

//        // delete: api/teams/5
//        [httpdelete("{id}")]
//        public actionresult delete(int id)
//        {
//            destination destination = db.destinations.singleordefault(a => a.destinationid == id);

//            if (destination == null)
//            {
//                return notfound();
//            }

//            db.destinations.remove(destination);
//            db.savechanges();
//            return ok();
//        }
//    }
//}
    

