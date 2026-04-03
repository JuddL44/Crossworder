using Crossworder.API.Models;

namespace Crossworder.API.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Words.Any()) return;

            var words = new List<Word>
            {
                new Word { Text = "air", Clues = new[] { "I just need some ____", "An inflatables insides", "Hot Balloon", "Ryan ____", "CPR Ingredient" } },
                new Word { Text = "arch", Clues = new[] { "McDonalds has two", "Bend, Curve", "As seen on bridges & roofs", "____ nemesis", "Common structural member" } },
                new Word { Text = "apple", Clues = new[] { "Newton's favorite fruit", "Billion dollar tech company", "Tim Cook's Child", "____ pie", "Temporary residence for worms" } },

                new Word { Text = "bar", Clues = new[] { "Protein rectangle", "Where one might grab a drink", "Singular jail restraint", "Mispelled comedian, Roseanne ____", "Crow, for breaking in" } },
                new Word { Text = "book", Clues = new[] { "____ smarts", "Primary product of Barnes & Noble", "The Bible, shortened", "Bill Holderman's '____ club'", "____ it, as in to run" } },
                new Word { Text = "baron", Clues = new[] { "Red pizza-chef", "Lowest order of The British Nobility", "Often mistaken for 'Barren'"} },

                new Word { Text = "car", Clues = new[] { "An object to get around", "Lincoln, Ford, Kia", "4 wheels", "Gen Z terminology for 'Cat'", "Modern day carriage"} },
                new Word { Text = "cant", Clues = new[] { "I just ____ do it.", "Not possible", "Avoidant, task disregarding", "____ back down", } },
                new Word { Text = "crown", Clues = new[] { "Royalty hat", "Tooth repair", "____ of thorns", "Take the ____", "An item every king deserves" } },

                new Word { Text = "den", Clues = new[] { "Lions ____", "Cozy home office", "Daniel in the ____", "Man cave, formally", "Fox's home" } },
                new Word { Text = "dark", Clues = new[] { "Absence of light", "____ness falls at night", "Shot in the ____", "____net browser", "Opposite of light-roast" } },
                new Word { Text = "draft", Clues = new[] { "NFL selection event", "Beer on tap", "First version of an essay", "Cold air sneaking in", "Military enrollment" } },

                new Word { Text = "eat", Clues = new[] { "Action during breakfast, lunch, and dinner", "___ your veggies", "Yum!", "Goal of Thanksgiving", "Cure to midnight cravings"} },
                new Word { Text = "east", Clues = new[] { "Spring equinox sunrise direction", "North, West, South", "Rightside of a compass", "New York, Maine, Florida"} },
                new Word { Text = "earth", Clues = new[] { "The Third Planet", "Planet with lots of water", "Home, as a whole", "Round.. or flat?", "Pangea's Home", "It's ____ day, clean your yard!" } },

                new Word { Text = "far", Clues = new[] { "First word of a Spider-Man movie", "In a galaxy, away", "____ out", "Exclamation of distance", "Miles and miles away"} },
                new Word { Text = "fame", Clues = new[] { "Said to change people", "Paparazzi attention factor", "and fortune", "Jennifer Lawrence's life-breaker", "and glory" } },
                new Word { Text = "flame", Clues = new[] { "Single hot source", "Fire escapee", "Travis Scott, La ____", "Fireplace main character", "Gaseous part of a fire"} },

                new Word { Text = "get", Clues = new[] { "Obtain an item", "____, put, post, delete", "scram!", "An animal's offspring", "Succeed in attaining"} },
                new Word { Text = "grow", Clues = new[] { "To expand", "____ a garden", "Ant man ability", "Grass verb, after rain", "Opposite of shrink"} },
                new Word { Text = "goats", Clues = new[] { "Best MVPs", "Lifestock that lives in mountains", "Sacrfice for cultists", "Heavily populated in India", "Screaming ____"} },

                new Word { Text = "hat", Clues = new[] { "Top apparel, Top ____", "Hair hider", "Magic Rabbit's living quarters", "Baseball cap", "Suffix of a Dr Seuss character" } },
                new Word { Text = "hoax", Clues = new[] { "A lie, a fab", "Lies, maybe on the internet", "Elaborate media stunt", "Product for a desire of sensationalism" } },
                new Word { Text = "hoops", Clues = new[] { "Two circular earrings", "Need two for basketball", "Multiple encircled bands", "Gardeners tool to support plants" } },

                new Word { Text = "ink", Clues = new[] { "Pen's blood", "Tattoo artist's medium", "Squid's defense mechanism", "Print cartridge fill", "____well on old desks" } },
                new Word { Text = "iron", Clues = new[] { "Wrinkle remover", "Man of Steel's lesser cousin", "Golf club type", "Stark's first name", "Pumping ____" } },
                new Word { Text = "ivory", Clues = new[] { "Elephant tusk material", "____ tower", "Soap brand", "Off-white shade", "Banned in trade since 1989" } },

                new Word { Text = "jar", Clues = new[] { "Mason ____", "Pickle's home", "Cookie ____", "Jolt or rattle", "Glass container with a lid" } },
                new Word { Text = "jest", Clues = new[] { "Court jester's trade", "Said in ____", "Joking around", "No seriously, I ____", "Lighthearted mockery" } },
                new Word { Text = "joint", Clues = new[] { "Where two bones meet", "A sketchy establishment", "Rolled smoke, informally", "____ly, as in together", "Carpentry connection" } },

                new Word { Text = "key", Clues = new[] { "Unlocks a door", "Florida ____s", "Piano component", "Most important, ___ ingredient", "Alicia ____s" } },
                new Word { Text = "knot", Clues = new[] { "Sailor's specialty", "Nautical speed unit", "Tie the ____", "Hair tangle", "Boy Scout badge requirement" } },
                new Word { Text = "kneel", Clues = new[] { "Kaepernick's protest", "Knight's greeting to a king", "Proposal position", "Show of reverence", "Get down on one ____" } },

                new Word { Text = "lag", Clues = new[] { "Gamer's worst enemy", "Fall behind", "Jet ____", "Wi-Fi complaint", "Delay in response" } },
                new Word { Text = "lore", Clues = new[] { "Game backstory", "Legend and myth", "Star Wars deep ____", "Tolkien's specialty", "____master" } },
                new Word { Text = "lunar", Clues = new[] { "Moon-related", "____ eclipse", "Apollo mission destination", "Opposite of solar", "Werewolf trigger" } },

                new Word { Text = "map", Clues = new[] { "Dora's best friend", "Road trip essential", "X marks the spot", "Google ____", "Cartographer's creation" } },
                new Word { Text = "maze", Clues = new[] { "Corn field attraction", "Minotaur's home", "Hampton Court tourist trap", "Rat's challenge", "Dead ends galore" } },
                new Word { Text = "mercy", Clues = new[] { "Spare someone", "Overwatch healer", "Kanye's 2012 banger", "Please, have ____!", "Opposite of cruelty" } },

                new Word { Text = "nap", Clues = new[] { "Power ____", "Cat's favorite hobby", "Short daytime sleep", "Spanish siesta equivalent", "Kindergarten requirement" } },
                new Word { Text = "nest", Clues = new[] { "Bird's home", "Google's smart thermostat", "Empty ____ syndrome", "Cozy and settled in", "Egg holder up high" } },
                new Word { Text = "north", Clues = new[] { "Santa's direction", "Compass top", "Kanye's kid", "Game of Thrones, beyond the wall", "True ____, navigation term" } },

                new Word { Text = "oak", Clues = new[] { "Acorn's parent", "Strong as ____", "Common hardwood floor", "Sturdy furniture material", "Sherwood Forest staple" } },
                new Word { Text = "omen", Clues = new[] { "Bad sign", "1976 horror film", "Black cat superstition", "Fortune teller's finding", "Foreboding signal" } },
                new Word { Text = "orbit", Clues = new[] { "Earth around the sun", "Astronaut's path", "Gum brand", "Satellite route", "Gravity's leash" } },

                new Word { Text = "paw", Clues = new[] { "Dog's foot", "____ Patrol", "Grizzly swipe", "Paw ____dre", "Kitten's mitt" } },
                new Word { Text = "pine", Clues = new[] { "Christmas tree type", "____apple", "Longing for something", "Needle-leaf evergreen", "Air freshener scent" } },
                new Word { Text = "prism", Clues = new[] { "Pink Floyd album art", "Light splitter", "Rainbow maker", "Geometry glass shape", "NSA surveillance program" } },

                new Word { Text = "quo", Clues = new[] { "Status ____", "The ____, band", "Latin for 'which'", "Keep the ____, don't change", "High School Musical villain's goal" } },
                new Word { Text = "quiz", Clues = new[] { "Buzzfeed specialty", "Surprise ____", "Kahoot session", "Trivia's smaller cousin", "Teacher's pop ____" } },
                new Word { Text = "quill", Clues = new[] { "Porcupine's defense", "Shakespeare's pen", "Pre-ballpoint writing tool", "Guardians of the Galaxy member", "Dipped in inkwell" } },

                new Word { Text = "raw", Clues = new[] { "Uncooked steak", "WWE's Monday night show", "Unfiltered emotion", "Sushi prerequisite", "Gordon Ramsay's nightmare" } },
                new Word { Text = "reef", Clues = new[] { "Nemo's neighborhood", "Great Barrier ____", "Coral structure", "Diver's destination", "Ocean ecosystem" } },
                new Word { Text = "ridge", Clues = new[] { "Mountain's spine", "Doritos ____", "Raised narrow strip", "Tom ____", "Roof's peak" } },

                new Word { Text = "sap", Clues = new[] { "Tree's blood", "Maple syrup source", "Naive pushover", "Drain of energy", "Sticky trunk liquid" } },
                new Word { Text = "sage", Clues = new[] { "Thanksgiving stuffing herb", "Wise old man", "Olivia Rodrigo album", "Grey-green color", "Native American cleansing ritual" } },
                new Word { Text = "spine", Clues = new[] { "Book's binding edge", "Backbone", "Porcupine quill's cousin", "Chiropractor's focus", "33 vertebrae stack" } },

                new Word { Text = "tar", Clues = new[] { "Road paving material", "Cigarette byproduct", "Pit trap for mammoths", "Rooftop coating", "Black sticky substance" } },
                new Word { Text = "tide", Clues = new[] { "Laundry detergent", "Ocean's push and pull", "High and low ____", "Moon's doing", "Turn the ____" } },
                new Word { Text = "torch", Clues = new[] { "Olympic symbol", "British word for flashlight", "Burn it down, slangily", "Hunger Games tribute tribute item", "Cave explorer's tool" } },

                new Word { Text = "urn", Clues = new[] { "Ash holder", "Cremation container", "Fancy vase", "Coffee ____  at a buffet", "Cemetery staple" } },
                new Word { Text = "unit", Clues = new[] { "Measurement base", "Apartment, informally", "Military subdivision", "One piece of something", "ICU ____, hospital ward" } },
                new Word { Text = "ultra", Clues = new[] { "Beyond extreme", "Miami music festival", "____violet rays", "____marathon distance", "Kanye album" } },

                new Word { Text = "van", Clues = new[] { "Mystery Machine vehicle", "Cargo hauler", "Living in a ____ down by the river", "____guard", "Moving day rental" } },
                new Word { Text = "vale", Clues = new[] { "Farewell, poetically", "A valley", "____ of tears", "Colorado ski town", "Between two hills" } },
                new Word { Text = "vivid", Clues = new[] { "Bright and bold", "Ryzen graphics brand", "Crystal clear memory", "Opposite of dull", "____ly imagined" } },

                new Word { Text = "web", Clues = new[] { "Spider's trap", "World Wide ____", "Charlotte's ____", "Spiderman's tool", "Internet, casually" } },
                new Word { Text = "wade", Clues = new[] { "Walk through water", "Dwyane ____", "Roe v. ____", "Push through difficulty", "Shallow river crossing" } },
                new Word { Text = "width", Clues = new[] { "Horizontal measurement", "Pool lane dimension", "Length's partner", "How wide is it?", "CSS property" } },

                new Word { Text = "xis", Clues = new[] { "Plural of xi", "Greek letter group", "14th letter times two", "Fraternity set", "Xi's siblings" } },
                new Word { Text = "xbox", Clues = new[] { "Microsoft's console", "Halo's home", "PlayStation rival", "Green gaming giant", "360 degrees of fun" } },
                new Word { Text = "xenon", Clues = new[] { "Noble gas #54", "Headlight gas type", "Periodic table loner", "Colorless and odorless", "Flash lamp filler" } },

                new Word { Text = "yak", Clues = new[] { "Tibetan cattle", "Talk excessively", "Shaggy mountain beast", "Himalayan pack animal", "Chatter on and on" } },
                new Word { Text = "yard", Clues = new[] { "Grass to mow", "3 feet exactly", "Back ____ BBQ", "Prison outdoor time", "Scotland ____" } },
                new Word { Text = "yeast", Clues = new[] { "Bread's rising agent", "Brewery essential", "Single celled fungus", "Infection type, unfortunately", "Sourdough starter ingredient" } },

                new Word { Text = "zen", Clues = new[] { "Total inner peace", "Buddhist practice", "Chill to the max", "Garden with raked sand", "Honda model" } },
                new Word { Text = "zero", Clues = new[] { "Nothing, zip, nada", "Ground ____ ", "Absolute bottom", "Hero to ____", "Kelvin's stopping point" } },
                new Word { Text = "zones", Clues = new[] { "Time ____ confusion", "Plural comfort areas", "Zoning out's noun", "Climate regions", "End ____, football term" } },
            };

            context.Words.AddRange(words);
            context.SaveChanges();
        }
    }
}