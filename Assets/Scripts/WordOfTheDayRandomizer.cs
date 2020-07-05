using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WordOfTheDayRandomizer : MonoBehaviour
{

    List<string> words;
    List<string> definitions;
    System.Random rnd;
    int randomNumber;
    string randomWord;
    string randomDefinition;
    public TextMeshProUGUI word;
    public TextMeshProUGUI definition;

       

    // Start is called before the first frame update
    void Start()
    {
        // Create list with words
        words = new List<string>();

        // Create second list with corresponding definitions
        definitions = new List<string>();

        // Populate word list
        words.Add("Auspicious");
        words.Add("Euphoria");
        words.Add("Aplomb");
        words.Add("Copacetic");
        words.Add("Zonked");
        words.Add("Ameliorate");
        words.Add("Audacious");
        words.Add("Ebullient");
        words.Add("Iteration");
        words.Add("Beholden");
        words.Add("Umbra");
        words.Add("Refractory");
        words.Add("Categorical");
        words.Add("Prudent");
        words.Add("Insubstantial");
        words.Add("Habituate");
        words.Add("Bantering");
        words.Add("Retrospective");
        words.Add("Endearment");
        words.Add("Agog");
        words.Add("Iota");
        words.Add("Rendezvous");
        words.Add("Nexus");
        words.Add("Thematic");
        words.Add("Epic");
        words.Add("Bevy");
        words.Add("Acme");
        words.Add("Bawdy");
        words.Add("Anomalous");
        words.Add("Consort");
        words.Add("Prologue");
        words.Add("Escapade");
        words.Add("Assuage");
        words.Add("Opulent");
        words.Add("Verity");
        words.Add("Elicit");
        words.Add("Adroit");
        words.Add("Tenacious");
        words.Add("Disparity");
        words.Add("Optimal");
        words.Add("Schism");
        words.Add("Polyglot ");
        words.Add("Contentious  ");
        words.Add("Druthers ");
        words.Add("Fungible ");
        words.Add("Bevy ");
        words.Add("Persnickety ");
        words.Add("Implacable ");
        words.Add("Equinox ");
        words.Add("Unwieldy ");
        words.Add("Verbose ");
        words.Add("Exorbitant ");
        words.Add("Succinct ");
        words.Add("Inexorable ");
        words.Add("Veracity ");
        words.Add("Carp ");
        words.Add("Gist ");
        words.Add("Ineluctable ");
        words.Add("Sporadic ");
        words.Add("Anachronism");
        words.Add("Quintessence ");
        words.Add("Paraphernalia ");
        words.Add("Laissez-faire ");
        words.Add("Impetus ");
        words.Add("Desolate ");
        words.Add("Saga ");
        words.Add("Vicissitude ");
        words.Add("Marginalia ");
        words.Add("Rigamarole ");
        words.Add("Proclivity ");
        words.Add("Gregarious ");
        words.Add("Alacrity ");
        words.Add("Debacle ");
        words.Add("Rabble ");
        words.Add("Accolade");
        words.Add("Winnow ");
        words.Add("Obfuscate");
        words.Add("Genial ");
        words.Add("Exiguous ");
        words.Add("Foment ");
        words.Add("Laconic ");
        words.Add("Assiduous ");
        words.Add("Conversant ");
        words.Add("Debilitating ");
        words.Add("Thwart");
        words.Add("Penchant ");
        words.Add("Immutable ");
        words.Add("Brevity ");
        words.Add("Nomenclature ");
        words.Add("Truculent ");
        words.Add("Emulous ");
        words.Add("Quandary ");
        words.Add("Verity ");
        words.Add("Disparity ");
        words.Add("Banal ");
        words.Add("Perspicuity");
        words.Add("Resplendent ");
        words.Add("Bellwether ");
        words.Add("Cliché");
        words.Add("Courscant");
        words.Add("Embellishment");
        words.Add("Patriotism");
        words.Add("Peripatetic ");
        words.Add("Scrumptious ");
        words.Add("Sesquipedalian ");


        // Populate definition list
        definitions.Add("showing or suggesting that future success is likely ");
        definitions.Add("a feeling of great happiness ");
        definitions.Add("complete and confident composure ");
        definitions.Add("very satisfactory ");
        definitions.Add("very exhausted ");
        definitions.Add("to make better; improve ");
        definitions.Add("daring bold, extremely original ");
        definitions.Add("having or showing liveliness and enthusiasm ");
        definitions.Add("repetition ");
        definitions.Add("being under obligation for a favor ");
        definitions.Add("a shaded area ");
        definitions.Add("resisting control or authority: stubborn, unmanageable ");
        definitions.Add("absolute, unqualified ");
        definitions.Add("cautious; discreet ");
        definitions.Add("lacking material form or substance ");
        definitions.Add("make psychologically or physically used ");
        definitions.Add("cleverly amusing in tone ");
        definitions.Add("concerned with or related to the past ");
        definitions.Add("the act of showing affection ");
        definitions.Add("highly excited ");
        definitions.Add("a tiny or scarcely detectable amount ");
        definitions.Add("a meeting planned at a certain time and place ");
        definitions.Add("the means of connection between things linked in series ");
        definitions.Add("relating to or constituting a topic of discourse ");
        definitions.Add("very imposing or impressive; surpassing the ordinary ");
        definitions.Add("a flock of birds; large gathering ");
        definitions.Add("the highest point ");
        definitions.Add("humorously vulgar ");
        definitions.Add("deviating from the general or common order ");
        definitions.Add("keep company with ");
        definitions.Add("an introduction to a play ");
        definitions.Add("any carefree episode ");
        definitions.Add("ease, lessen pain ");
        definitions.Add("luxurious, sleek, affluent ");
        definitions.Add("truth, fact, reality ");
        definitions.Add("draw out by discussion ");
        definitions.Add("clever, skillful, dexterous ");
        definitions.Add("holding fast ");
        definitions.Add("difference ");
        definitions.Add("best ");
        definitions.Add("division, split ");
        definitions.Add("speaking or writing several languages; composed of elements from different languages; widely diverse (as in ethnic or cultural origins). Merchants in the resort city are adept at serving a polyglot clientele, and most can converse comfortable in several languages.");
        definitions.Add("likely to cause disagreement or argument; exhibiting an often perverse and wearisome tendency to quarrels and disputes. Although she is very pleasant in person, Katie has a tendency to become aggressive and contentious in online discussions.");
        definitions.Add("free choice: preference-- used especially in the phrase if one had one's druthers. If I had my druthers, I would spend the winter months in Southern California.");
        definitions.Add("being such that one part or quantity may be replaced by another equal part or quantity in the satisfaction of an obligation; interchangeable. Oil is a fungible commodity and its prices are determined in the global market.");
        definitions.Add("a large group or collection; a group of animals and especially quail. A bevy of barricaded fans waited for the singer to go to his limousine parked outside the hotel.");
        definitions.Add("fussy about small details: fastidious; having the characteristics of a snob; requiring great precision. Traditionally, people have been a bit harsh on lexicographers, painting us as persnickety, nerdy, obsessive-compulsive types.");
        definitions.Add("not capable of being appeased, significantly changed, or mitigated. They met implacable opposiiton from education groups and others who didn't want the General Fund to lose the revenue.");
        definitions.Add("either of the two times each year (about March 21 and September 23) when the sun corsses the equator. Though many in the U.S. and Canada consider summer to end on Labour Day, the autumnal equinox marks the true beginning of autumn.");
        definitions.Add("not easily managed, handled, or used (as because of bulk, weight, complexity, or awkwardness): cumbersome. The futon mattress was heavy and unwieldy, and without any straps to hold onto, the two roommates struggled to carry it up the stairs.");
        definitions.Add("containing more words than necessary: wordy; impaired by wordiness. While others wrote spare, personal, ironic plays, Wilson's were big, verbose and passionate...");
        definitions.Add("exceeding the customary or appropriate limits in intensity, quality, amount, or size. I asked what the rent was for the apartment, and my jaw dropped when the landlord quoted me an exorbitant price.");
        definitions.Add("marked by compact precise expression without wasted words. Diana gave a succinct summary of the meeting to those of us who were unable to attend.");
        definitions.Add("not to be persuaded, moved, or stopped: relentless. The rise of cloud computing is rapid, inexorable and causing huge upheaval in the tech industry.");
        definitions.Add("conformity with truth or fact: accuracy. The prosecuting attorney doubted the veracity of some of the defense witness's testimony and reminded him that he was under oath.");
        definitions.Add("to find fault or complain querulously. Critics have been carping endlessly that tonight's Oscars may be the most snoozeworthy and least attractive to mainstream audiences in years.");
        definitions.Add("the main point or part: essence. I didn't catch every word, but I heard enough to get the gist of the debate.");
        definitions.Add("not to be avoided, changed or resisted: inevitable. Some aspects of aging did prove to be ineluctable. The oldest cyclists had less muscular power and mass than those in their 50s and early 60s.");
        definitions.Add("occurring occasionally, singly, or in irregular or random instances. Since the region only receives sporadic rainfall, it is not conducive to growing most crops.");
        definitions.Add("a person or thing that is chronologically out of place; one from a former age that is incongruous in the present. Manual typewriters and slide rules are often regarded as anchronisms in the age of computers.");
        definitions.Add("the essence of a thing, in its purest and most concentrated form; the most typical example or representative. Roasting marshmallows over an open fire is the quintessence of the camping experience.");
        definitions.Add("articles of equipment: furnishings. Over the years, he'd been into ... hiking, grilling and smoking meat, golfing, collecting bar paraphernalia, and kayak fishing.");
        definitions.Add("a doctrine opposing governmental interference in economic affairs; abstention from direction or interference. Critics of laissez-faire economics point out, accurately, that markets are not always self-correcting.");
        definitions.Add("a driving force; incentive; stimulation or encouragement resulting in incresased activity. The high salary and generous benefits package were impetus enough to apply for the job.");
        definitions.Add("deserted, abandoned; forsaken, lonely; dilapidated; barren, lifeless; cheerless, gloomy. The landscape looks truly desolate in the winter, but when it blossoms in the spring, it can be surprisingly beautiful.");
        definitions.Add("a story of heroic deeds; a long detailed account. The film depicts the saga of a shipwrecked family and the efforts of its six members to remain strong in the face of danger.");
        definitions.Add("an unexpectied change or fluctuation; a difficulty or hardship usually beyond one's control. I would worry about everything: home repairs, trip planning, medical issues and all the vicissitudes of old age.");
        definitions.Add("Marginal notes or embellishments (as in a book); nonessential items. Read between the lines of an old family recipe... The scrawled marginalia and cooking stains, the collective memory of shared feasts.");
        definitions.Add("a complex and sometimes ritualistic procedure. Just working my way through the rigmarole of retrieving lost passwords and locating my investments was bad enough.");
        definitions.Add("an inclination or predisposition; especially an inherent inclination toward something objectionable. His impressive arm strength has been superseded by a proclivity to throw interceptions...");
        definitions.Add("marked by or indicating a liking for companionshoip: sociable. (He) is known for his gregarious, welcoming attitude on the job.");
        definitions.Add("promptness in response: cheerful readines. The sommelier responded with alacrity to my question about which wine paired best with our entrees.");
        definitions.Add("a great disaster, a complete failure: fiasco. Volunteers from around the nation have joined together to aid the communities affected by the oill spill debacle.");
        definitions.Add("a disorganized or confused collection of things; a disorganized or disorderly crowd of people: mob. The university chancellor required extra security to help get him through the rabble of protestors.");
        definitions.Add("a mark of acknowledgement: award; an expression of praise. The movie's special effects have drawn accolades from both fans and critics");
        definitions.Add("to examine; sift for the purpose of separating the bad from the good. Her apology was so craftily penned that it was difficult to winnow the sincerity from the sarcasm.");
        definitions.Add("to make obscure, confuse. The defense attorney tried to obfuscate the facts with irrelevant issues.");
        definitions.Add("cheerful; amiable. The man's rotund and genial made hime the perfect Santa Claus.");
        definitions.Add("small, scanty, meager. The company offered me such an exiguous salary that I did not accept the job.");
        definitions.Add("stir up, arouse, incite. Though he seemed loyal in public, he worked behind the scenses to foment revolution.");
        definitions.Add("brief, terse. He issued his staff a few laconic instructions before he left the office.");
        definitions.Add("constant, persistent. An assiduous reader oftne makes a good scholar.");
        definitions.Add("Familiar or acquainted with, especialy as a result of study or experience; well versed in. The attorney is conversant with crminal trial proceedings.");
        definitions.Add("Making one weak or very tired by sapping one's energy or health. Constant excesses are debilitating to even the strongest constitution.");
        definitions.Add("Frustrate, prevent. She expected her parents to thwart her plans.");
        definitions.Add("to lean or incline toward an object, concept, or action. The rock star has a penchant for wild parties and fast cars.");
        definitions.Add("unchangeable, unvarying, steadfast. The planets move in immutable orbits.");
        definitions.Add("shortness of duration, conciseness, terseness. Brevity is good.");
        definitions.Add("the act or process or an instance of naming; a system or set of terms. The nomenclature of geologic formations is complex yet logical.");
        definitions.Add("aggressive, savage. He gave such a truculent evaluation of the new member's first speech that the member did not attend the next meeting.");
        definitions.Add("imitative, desirous of rivaling. Because he is emulous of great orators, he constantly tries to give speeches.");
        definitions.Add("a state of perplexity or doubt; dilemma. The complexity of calculus leaves most students in a quandary.");
        definitions.Add("truth, fact, reality. In verity the matter is exactly as reported.");
        definitions.Add("difference. Such a disparity exists in their ages that I don't see how the marriage can work.");
        definitions.Add("trite, commonplace, uninspired. The pompous speaker bored his audience with banal remarks.");
        definitions.Add("clearness, lucidity. The perspicuity of her arguments made her opponents see her side.");
        definitions.Add("brilliant, lustrous. She wore a resplendent gown to the reception. ");
        definitions.Add("A person or thing that assumes the leadership or forefront as of a profession or industry.");
        definitions.Add("A trite phrase or expression, something overused that has become commonplace.");
        definitions.Add("Flashes of light, glittering, sparkling, gleaming, quivering, or scintillating.");
        definitions.Add("An elaborative addition to a statement being fictitious.");
        definitions.Add("Love and devotion to one’s country.");
        definitions.Add("Walking, travelling about, roaming, wandering, vagrant.");
        definitions.Add("Delightful, especially delicious.");
        definitions.Add("Given to using big words.");




    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Generate random position in list, based on list length. Display word and corresponding definition
    public void RandomWord()
    {
        rnd = new System.Random();
        randomNumber = rnd.Next(words.Count);
        randomWord = words[randomNumber];
        randomDefinition = definitions[randomNumber];

        word.text = randomWord;
        definition.text = randomDefinition;

    }
}
