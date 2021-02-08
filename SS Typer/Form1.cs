using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Input;
using WMPLib;

namespace SS_Typer
{
    public partial class FormSSTyper : Form
    {
        Random generator = new Random();
        List<string> listQuest = new List<string>();

        int display = 0;
        bool displayTimeExtended = false;
        bool display60Secs = false;
        bool display30Secs = false;
        bool display15Secs = false;
        bool displayCountdown = false;

        int index = 0;
        int score = 0;
        int time = 120;
        int requirement = 50;
        int tempReq = 0;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        WindowsMediaPlayer loopSound = new WindowsMediaPlayer();
        WindowsMediaPlayer normSound = new WindowsMediaPlayer();
        

        public FormSSTyper()
        {
            InitializeComponent();
        }

        private void FormSSTyper_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            labelCD1.Text = ""; labelCD2.Text = ""; labelCD3.Text = ""; labelCD4.Text = ""; labelCD5.Text = "";
            labelTimeExtended.Visible = false;
            label60Secs.Visible = false;
            label30Secs.Visible = false;
            label15Secs.Visible = false;

            loopSound.URL = resourcesPath + "SC SS.wav";
            loopSound.settings.setMode("loop", true);
            loopSound.settings.mute = false;

            // Database 5 words per line
            InputData("abacus"); InputData("abalone"); InputData("abandon"); InputData("abasement"); InputData("abbreviate"); // A
            InputData("abdicate"); InputData("abdomen"); InputData("abduction"); InputData("abetment"); InputData("abeyance");
            InputData("abhor"); InputData("abide"); InputData("ability"); InputData("abnormal"); InputData("aboard");
            InputData("abolish"); InputData("abominable"); InputData("aborigine"); InputData("abortion"); InputData("about");
            InputData("above"); InputData("abracadabra"); InputData("abrasive"); InputData("abroad"); InputData("abrupt");
            InputData("absence"); InputData("absolute"); InputData("absorb"); InputData("absurd"); InputData("abuse");
            InputData("abyss"); InputData("academic"); InputData("accelerate"); InputData("accept"); InputData("access");
            InputData("accident"); InputData("accommodate"); InputData("accompany"); InputData("accord"); InputData("accordion");
            InputData("account"); InputData("accumulate"); InputData("accuracy"); InputData("accuse"); InputData("acetic");
            InputData("achieve"); InputData("acknowledge"); InputData("acorn"); InputData("acoustic"); InputData("acquaintance");
            
            InputData("acquire"); InputData("acrobat"); InputData("across"); InputData("action"); InputData("activate");
            InputData("activity"); InputData("actor"); InputData("actual"); InputData("acute"); InputData("adagio");
            InputData("adamant"); InputData("adaption"); InputData("addict"); InputData("address"); InputData("adept");
            InputData("adhesion"); InputData("adjective"); InputData("adjoin"); InputData("adjust"); InputData("administration");
            InputData("admire"); InputData("admit"); InputData("adopt"); InputData("adore"); InputData("adult");
            InputData("advance"); InputData("advantage"); InputData("adventure"); InputData("adverb"); InputData("advertisement");
            InputData("advise"); InputData("advocate"); InputData("aegis"); InputData("aerodynamics"); InputData("aerial");
            InputData("aeroplane"); InputData("affair"); InputData("affect"); InputData("affinity"); InputData("affirmative");
            InputData("afford"); InputData("afloat"); InputData("afraid"); InputData("africa"); InputData("after");
            InputData("again"); InputData("agency"); InputData("aggregate"); InputData("agile"); InputData("agony");
            //100
            InputData("agree"); InputData("ahead"); InputData("ailment"); InputData("aircraft"); InputData("airborne");
            InputData("airline"); InputData("airport"); InputData("aisle"); InputData("alabaster"); InputData("alarm");
            InputData("albino"); InputData("albatross"); InputData("alcohol"); InputData("alert"); InputData("algae");
            InputData("algeria"); InputData("alien"); InputData("align"); InputData("alkaline"); InputData("allegation");
            InputData("allegro"); InputData("allergy"); InputData("allies"); InputData("allowance"); InputData("almanac");
            InputData("almighty"); InputData("almost"); InputData("alone"); InputData("alpha"); InputData("altar");
            InputData("alternative"); InputData("although"); InputData("alumunium"); InputData("altitude"); InputData("alveolus");
            InputData("amateur"); InputData("ambassador"); InputData("amber"); InputData("ambition"); InputData("ambush");
            InputData("amends"); InputData("america"); InputData("amethyst"); InputData("amnesia"); InputData("amorous");
            InputData("amount"); InputData("amphibian"); InputData("amplifier"); InputData("amulet"); InputData("amusement");

            InputData("anemia"); InputData("analogy"); InputData("anatomy"); InputData("ancestor"); InputData("anchor");
            InputData("angel"); InputData("anger"); InputData("anguish"); InputData("animal"); InputData("animation");
            InputData("ankle"); InputData("annihilate"); InputData("anniversary"); InputData("announcement"); InputData("anomaly");
            InputData("anonymous"); InputData("another"); InputData("antagonist"); InputData("antelope"); InputData("anthem");
            InputData("anticipate"); InputData("antibody"); InputData("antidote"); InputData("antique"); InputData("anybody");
            InputData("anything"); InputData("aorta"); InputData("apartement"); InputData("apiary"); InputData("apocalypse");
            InputData("apologize"); InputData("apostle"); InputData("apparel"); InputData("appeal"); InputData("appear");
            InputData("appetite"); InputData("apple"); InputData("applicance"); InputData("appointment"); InputData("appreciate");
            InputData("apprehend"); InputData("approach"); InputData("approve"); InputData("april"); InputData("aquamarine");
            InputData("arabian"); InputData("arbiter"); InputData("arcade"); InputData("archaeology"); InputData("archangel");
            //200
            InputData("archbishop"); InputData("archer"); InputData("archipelago"); InputData("architect"); InputData("archives");
            InputData("arena"); InputData("argue"); InputData("arise"); InputData("armada"); InputData("armor");
            InputData("aroma"); InputData("around"); InputData("arrange"); InputData("arrest"); InputData("arrogant");
            InputData("arsenic"); InputData("artery"); InputData("artifact"); InputData("artificial"); InputData("artillery");
            InputData("ascend"); InputData("asian"); InputData("asparagus"); InputData("aspen"); InputData("asphalt");
            InputData("aspire"); InputData("aspirin"); InputData("assassin"); InputData("assault"); InputData("assertive");
            InputData("asset"); InputData("assign"); InputData("assist"); InputData("assume"); InputData("asterisk");
            InputData("asthma"); InputData("astonish"); InputData("astray"); InputData("astrology"); InputData("astronaut");
            InputData("asylum"); InputData("atheism"); InputData("athlete"); InputData("atlantic"); InputData("atmosphere");
            InputData("attach"); InputData("attack"); InputData("attend"); InputData("attract"); InputData("attitude");

            InputData("attribute"); InputData("auction"); InputData("audacity"); InputData("audio"); InputData("audition");
            InputData("augment"); InputData("august"); InputData("aurora"); InputData("australia"); InputData("author");
            InputData("authority"); InputData("autodidact"); InputData("automate"); InputData("autumn"); InputData("available");
            InputData("avenge"); InputData("average"); InputData("avert"); InputData("aviation"); InputData("avocado");
            InputData("avoid"); InputData("awake"); InputData("award"); InputData("awesome"); InputData("azalea");
            InputData("babble"); InputData("baboon"); InputData("bachelor"); InputData("bacillus"); InputData("backache"); // B
            InputData("backbone"); InputData("background"); InputData("bacon"); InputData("bacteria"); InputData("badge");
            InputData("badger"); InputData("badminton"); InputData("baggage"); InputData("baker"); InputData("balance");
            InputData("balcony"); InputData("ballad"); InputData("ballistic"); InputData("ballpoint"); InputData("bamboo");
            InputData("banana"); InputData("bandage"); InputData("bandit"); InputData("banish"); InputData("bankrupt");
            // 300
            InputData("banquet"); InputData("baptism"); InputData("barbarian"); InputData("barber"); InputData("bargain");
            InputData("barnacle"); InputData("barrel"); InputData("barricade"); InputData("barter"); InputData("bartender");
            InputData("baseball"); InputData("basement"); InputData("basic"); InputData("basket"); InputData("basketball");
            InputData("bathroom"); InputData("battery"); InputData("battleship"); InputData("bayonet"); InputData("bazaar");
            InputData("beach"); InputData("beacon"); InputData("beaker"); InputData("beard"); InputData("beast");
            InputData("beater"); InputData("beautiful"); InputData("beaver"); InputData("because"); InputData("began");
            InputData("beginner"); InputData("behavior"); InputData("behind"); InputData("beige"); InputData("belgian");
            InputData("belief"); InputData("bellow"); InputData("belong"); InputData("bench"); InputData("beneath");
            InputData("benefit"); InputData("benevolent"); InputData("bermuda"); InputData("berry"); InputData("beside");
            InputData("besides"); InputData("bestow"); InputData("betray"); InputData("better"); InputData("between");

            InputData("beverage"); InputData("beware"); InputData("beyond"); InputData("bible"); InputData("bicarbonate");
            InputData("bicker"); InputData("bicycle"); InputData("bidder"); InputData("bikini"); InputData("bilateral");
            InputData("billion"); InputData("binary"); InputData("binder"); InputData("bingo"); InputData("binoculars");
            InputData("binomial"); InputData("biographer"); InputData("biology"); InputData("bipolar"); InputData("birthday");
            InputData("biscuit"); InputData("bishop"); InputData("bison"); InputData("bitter"); InputData("bivalve");
            InputData("blabber"); InputData("blackberry"); InputData("blacklist"); InputData("blackjack"); InputData("blade");
            InputData("blame"); InputData("blank"); InputData("blaspheme"); InputData("blast"); InputData("blaze");
            InputData("blemish"); InputData("blender"); InputData("bless"); InputData("blind"); InputData("blindfold");
            InputData("blink"); InputData("block"); InputData("blonde"); InputData("blood"); InputData("bloomer");
            InputData("blossom"); InputData("blower"); InputData("blowgun"); InputData("blueberry"); InputData("blunt");
            // 400
            InputData("blush"); InputData("board"); InputData("boarder"); InputData("boathouse"); InputData("bodyguard");
            InputData("boogle"); InputData("bohemian"); InputData("boiler"); InputData("bolster"); InputData("bombardier");
            InputData("bomber"); InputData("bonanza"); InputData("bonbon"); InputData("bondage"); InputData("bonnet");
            InputData("boner"); InputData("boobytrap"); InputData("bookworm"); InputData("boomerang"); InputData("booster");
            InputData("booth"); InputData("bootstrap"); InputData("border"); InputData("boring"); InputData("borrow");
            InputData("botany"); InputData("bottle"); InputData("bottom"); InputData("bought"); InputData("boulevard");
            InputData("bounce"); InputData("bound"); InputData("bounty"); InputData("bowler"); InputData("boxer");
            InputData("boyfriend"); InputData("brace"); InputData("bracket"); InputData("brain"); InputData("brake");
            InputData("branch"); InputData("brandy"); InputData("brass"); InputData("brave"); InputData("breach");
            InputData("bread"); InputData("break"); InputData("breakdown"); InputData("breakfast"); InputData("breast");

            InputData("breath"); InputData("breech"); InputData("breeder"); InputData("breeze"); InputData("bribe");
            InputData("brick"); InputData("bridge"); InputData("brief"); InputData("brigade"); InputData("bright");
            InputData("brilliance"); InputData("brine"); InputData("bristle"); InputData("british"); InputData("broad");
            InputData("broadcast"); InputData("broccoli"); InputData("brochure"); InputData("broiler"); InputData("broker");
            InputData("bronze"); InputData("brooch"); InputData("broom"); InputData("brother"); InputData("brought");
            InputData("brown"); InputData("browse"); InputData("brush"); InputData("brutal"); InputData("bubble");
            InputData("bucket"); InputData("buckle"); InputData("buddha"); InputData("budget"); InputData("buffalo");
            InputData("buffer"); InputData("buffet"); InputData("buggy"); InputData("build"); InputData("bulgarian");
            InputData("bulge"); InputData("bulldoze"); InputData("bullet"); InputData("bully"); InputData("bumper");
            InputData("bundle"); InputData("bungalow"); InputData("bunker"); InputData("bunny"); InputData("buoyant");
            //500
            InputData("burden"); InputData("bureau"); InputData("burglar"); InputData("burial"); InputData("burma");
            InputData("burnout"); InputData("burrow"); InputData("burst"); InputData("business"); InputData("butcher");
            InputData("butter"); InputData("butterfly"); InputData("button"); InputData("buzzer"); InputData("bygone");
            InputData("cabana"); InputData("cabaret"); InputData("cabbage"); InputData("cabinet"); InputData("cable"); // C
            InputData("cachet"); InputData("cactus"); InputData("caddie"); InputData("cadet"); InputData("cafetaria");
            InputData("caffein"); InputData("calamity"); InputData("calcium"); InputData("calculate"); InputData("calendar");
            InputData("caliber"); InputData("calibrate"); InputData("calipers"); InputData("calligraphy"); InputData("calypso");
            InputData("camshaft"); InputData("cambodian"); InputData("camel"); InputData("camouflage"); InputData("campus");
            InputData("canadian"); InputData("canal"); InputData("canary"); InputData("cancel"); InputData("cancer");
            InputData("candid"); InputData("candle"); InputData("candy"); InputData("canine"); InputData("cannibal");

            InputData("cannon"); InputData("cannot"); InputData("canon"); InputData("canteen"); InputData("canton");
            InputData("canvas"); InputData("canyon"); InputData("capability"); InputData("capacity"); InputData("capital");
            InputData("capitation"); InputData("caprice"); InputData("capricorn"); InputData("capsule"); InputData("captain");
            InputData("caption"); InputData("captive"); InputData("capture"); InputData("caramel"); InputData("carbide");
            InputData("caravan"); InputData("carbide"); InputData("carbohydrate"); InputData("carbon"); InputData("carcinogen");
            InputData("cards"); InputData("cardinal"); InputData("cardio"); InputData("career"); InputData("careful");
            InputData("caress"); InputData("cargo"); InputData("caribbean"); InputData("carnage"); InputData("carnival");
            InputData("carousel"); InputData("carpenter"); InputData("carpet"); InputData("carport"); InputData("carrier");
            InputData("carrot"); InputData("cartel"); InputData("cartoon"); InputData("catridge"); InputData("carve");
            InputData("casein"); InputData("cashew"); InputData("cassava"); InputData("cassette"); InputData("castle");
            // 600
            InputData("casual"); InputData("catalysm"); InputData("catalogue"); InputData("cataract"); InputData("catapult");
            InputData("catastrophe"); InputData("catch"); InputData("categorical"); InputData("category"); InputData("caterpillar");
            InputData("catfish"); InputData("cathedral"); InputData("catholic"); InputData("cattle"); InputData("cauldron");
            InputData("cauliflower"); InputData("causal"); InputData("caution"); InputData("cavalry"); InputData("cavern");
            InputData("caviar"); InputData("cedar"); InputData("celebrate"); InputData("celery"); InputData("celestial");
            InputData("cellar"); InputData("cemetery"); InputData("center"); InputData("central"); InputData("century");
            InputData("centrifuge"); InputData("centripetal"); InputData("cereal"); InputData("ceremony"); InputData("certain");
            InputData("certificate"); InputData("certify"); InputData("cervical"); InputData("chain"); InputData("chairman");
            InputData("chalet"); InputData("challenge"); InputData("chamber"); InputData("chameleon"); InputData("chance");
            InputData("chancellor"); InputData("change"); InputData("channel"); InputData("chaos"); InputData("chapel");

            InputData("chapter"); InputData("character"); InputData("charade"); InputData("charge"); InputData("chariot");
            InputData("charity"); InputData("charm"); InputData("chart"); InputData("chartreuse"); InputData("chase");
            InputData("chasm"); InputData("chassis"); InputData("chastity"); InputData("chatter"); InputData("chauvinism");
            InputData("cheap"); InputData("cheat"); InputData("check"); InputData("checkerboard"); InputData("checkmate");
            InputData("cheerful"); InputData("cheese"); InputData("chemical"); InputData("chemise"); InputData("cherry");
            InputData("chest"); InputData("chestnut"); InputData("chick"); InputData("chicken"); InputData("chief");
            InputData("chiffon"); InputData("child"); InputData("chili"); InputData("childlish"); InputData("children");
            InputData("chill"); InputData("chime"); InputData("chimera"); InputData("chimp"); InputData("china");
            InputData("chinese"); InputData("chipmunk"); InputData("chipper"); InputData("chisel"); InputData("chivalry");
            InputData("chlorine"); InputData("chocolate"); InputData("choice"); InputData("choir"); InputData("choke");
            // 700
            InputData("cholesterol"); InputData("choose"); InputData("chopper"); InputData("chopsticks"); InputData("choral");
            InputData("chore"); InputData("choreographer"); InputData("chortle"); InputData("chorus"); InputData("chosen");
            InputData("christ"); InputData("christian"); InputData("christmas"); InputData("chromatic"); InputData("chrome");
            InputData("chronicle"); InputData("chronology"); InputData("chrysalis"); InputData("chubby"); InputData("chuckle");
            InputData("chump"); InputData("chunk"); InputData("church"); InputData("cicada"); InputData("cigar");
            InputData("cinema"); InputData("circle"); InputData("circuit"); InputData("circumflex"); InputData("circumstance");
            InputData("circus"); InputData("citadel"); InputData("citizen"); InputData("citric"); InputData("citrus");
            InputData("citronella"); InputData("civic"); InputData("civil"); InputData("civillian"); InputData("clabber");
            InputData("clack"); InputData("claim"); InputData("clamber"); InputData("clamor"); InputData("clamp");
            InputData("clapboard"); InputData("clapper"); InputData("clarify"); InputData("clarinet"); InputData("clarity");

            InputData("clash"); InputData("class"); InputData("classic"); InputData("classified"); InputData("classmate");
            InputData("classy"); InputData("clatter"); InputData("clause"); InputData("clean"); InputData("cleanse");
            InputData("clear"); InputData("cleat"); InputData("cleave"); InputData("clergy"); InputData("clerk");
            InputData("clever"); InputData("client"); InputData("cliff"); InputData("climax"); InputData("climber");
            InputData("cling"); InputData("clink"); InputData("clipper"); InputData("cloak"); InputData("clockwork");
            InputData("close"); InputData("closet"); InputData("clothes"); InputData("cloud"); InputData("clove");
            InputData("cluck"); InputData("clumsy"); InputData("clunk"); InputData("clutch"); InputData("coagulate");
            InputData("coast"); InputData("coaster"); InputData("cobalt"); InputData("cockcrow"); InputData("cocktail");
            InputData("coddle"); InputData("codify"); InputData("coexist"); InputData("coffee"); InputData("coffin");
            InputData("cognac"); InputData("cohort"); InputData("coincidence"); InputData("collaborate"); InputData("collapse");
            // 800
            InputData("collateral"); InputData("collection"); InputData("collapse"); InputData("college"); InputData("collide");
            InputData("collision"); InputData("colloid"); InputData("collusion"); InputData("colonialism"); InputData("color");
            InputData("colossal"); InputData("column"); InputData("combat"); InputData("combine"); InputData("combination");
            InputData("combustion"); InputData("comedian"); InputData("comedy"); InputData("comfortable"); InputData("comical");
            InputData("command"); InputData("commando"); InputData("commence"); InputData("comment"); InputData("commerce");
            InputData("commission"); InputData("commit"); InputData("common"); InputData("communicate"); InputData("communist");
            InputData("commuter"); InputData("company"); InputData("comparable"); InputData("comparative"); InputData("compass");
            InputData("compensation"); InputData("competent"); InputData("competition"); InputData("compilation"); InputData("complement");
            InputData("complete"); InputData("complication"); InputData("compliment"); InputData("component"); InputData("composer");
            InputData("composition"); InputData("compost"); InputData("compound"); InputData("compressor"); InputData("compromise");

            InputData("computer"); InputData("comrade"); InputData("comsat"); InputData("conceal"); InputData("conceive");
            InputData("concentrate"); InputData("concept"); InputData("conclusion"); InputData("concord"); InputData("concrete");
            InputData("condense"); InputData("conditional"); InputData("conductive"); InputData("confection"); InputData("confederate");
            InputData("confess"); InputData("confide"); InputData("confident"); InputData("confidental"); InputData("confine");
            InputData("confirm"); InputData("consficate"); InputData("conflict"); InputData("confront"); InputData("congratulate");
            InputData("connect"); InputData("connetive"); InputData("conquest"); InputData("conscience"); InputData("consequence");
            InputData("consign"); InputData("consist"); InputData("console"); InputData("consort"); InputData("constable");
            InputData("constitute"); InputData("construct"); InputData("contemplate"); InputData("contention"); InputData("continent");
            InputData("convection"); InputData("conversation"); InputData("converse"); InputData("convert"); InputData("convict");
            InputData("cooperate"); InputData("copied"); InputData("copyright"); InputData("cordial"); InputData("cordon");
            // 900
            InputData("corker"); InputData("corner"); InputData("corolla"); InputData("correction"); InputData("corruptor");
            InputData("cosmic"); InputData("cosmos"); InputData("costume"); InputData("cough"); InputData("countdown");
            InputData("counter"); InputData("counterfeit"); InputData("countess"); InputData("coupon"); InputData("courier");
            InputData("court"); InputData("covert"); InputData("cover"); InputData("crack"); InputData("crane");
            InputData("crash"); InputData("crater"); InputData("crawl"); InputData("creak"); InputData("credit");
            InputData("creepy"); InputData("criminal"); InputData("cripple"); InputData("critism"); InputData("critique");
            InputData("crossroad"); InputData("croup"); InputData("crucial"); InputData("cruise"); InputData("crumble");
            InputData("crunch"); InputData("crusade"); InputData("crush"); InputData("cucumber"); InputData("cultivation");
            InputData("cumulus"); InputData("cupid"); InputData("cupola"); InputData("cursory"); InputData("curtail");
            InputData("cushion"); InputData("custard"); InputData("custody"); InputData("customer"); InputData("cuticle");

            InputData("dachshund"); InputData("daily"); InputData("daisy"); InputData("damper"); InputData("damson"); // D
            InputData("dance"); InputData("dangerous"); InputData("darken"); InputData("dashboard"); InputData("datebook");
            InputData("daughter"); InputData("dawdler"); InputData("daylight"); InputData("daybreak"); InputData("daytime");
            InputData("deactivate"); InputData("deadline"); InputData("deadlock"); InputData("deathblow"); InputData("debase");
            InputData("debit"); InputData("debater"); InputData("debris"); InputData("debunk"); InputData("decapitate");
            InputData("decedent"); InputData("deceiver"); InputData("decide"); InputData("declare"); InputData("decline");
            InputData("decorate"); InputData("decrease"); InputData("dedicate"); InputData("deduce"); InputData("deduction");
            InputData("deductive"); InputData("defective"); InputData("defecate"); InputData("defiant"); InputData("deform");
            InputData("defrost"); InputData("degree"); InputData("dehydration"); InputData("deliacy"); InputData("demented");
            InputData("demerit"); InputData("democrate"); InputData("democratic"); InputData("democrate"); InputData("demolish");
            // 1000
            InputData("demon"); InputData("demonstrate"); InputData("dental"); InputData("depend"); InputData("deposit");
            InputData("depot"); InputData("deprecate"); InputData("depress"); InputData("deprive"); InputData("dermatology");
            InputData("descend"); InputData("desert"); InputData("design"); InputData("desire"); InputData("desist");
            InputData("despair"); InputData("desperado"); InputData("desperate"); InputData("despite"); InputData("destination");
            InputData("detail"); InputData("detect"); InputData("detection"); InputData("detective"); InputData("detergent");
            InputData("determine"); InputData("detest"); InputData("detonator"); InputData("detractor"); InputData("develop");
            InputData("deviant"); InputData("deviation"); InputData("devil"); InputData("devise"); InputData("devoid");
            InputData("devour"); InputData("dewdrop"); InputData("dialogue"); InputData("diaper"); InputData("dictate");
            InputData("diesel"); InputData("differ"); InputData("difference"); InputData("difficult"); InputData("diffuse");
            InputData("digest"); InputData("digger"); InputData("dignify"); InputData("diligence"); InputData("diminish");

            InputData("dimple"); InputData("dipper"); InputData("direction"); InputData("directory"); InputData("dirty");
            InputData("disagree"); InputData("disappear"); InputData("disband"); InputData("disciple"); InputData("discovery");
            InputData("discriminate"); InputData("disgrace"); InputData("disguise"); InputData("disgust"); InputData("dislike");
            InputData("dismay"); InputData("dismount"); InputData("disown"); InputData("disparity"); InputData("dispel");
            InputData("displace"); InputData("disposition"); InputData("disqualify"); InputData("dissent"); InputData("dissipate");
            InputData("distance"); InputData("distend"); InputData("distinct"); InputData("distortion"); InputData("distress");
            InputData("disturb"); InputData("ditch"); InputData("diver"); InputData("diverse"); InputData("divert");
            InputData("divorce"); InputData("dizzy"); InputData("docker"); InputData("doctor"); InputData("dodge");
            InputData("does"); InputData("domain"); InputData("dominate"); InputData("domino"); InputData("donation");
            InputData("donor"); InputData("doorway"); InputData("dossier"); InputData("doubt"); InputData("downfall");
            // 1100
            InputData("downhill"); InputData("downward"); InputData("dragon"); InputData("dragonfly"); InputData("drain");
            InputData("drainage"); InputData("dramatics"); InputData("dramatist"); InputData("draught"); InputData("drawl");
            InputData("dream"); InputData("dreamt"); InputData("dredge"); InputData("dress"); InputData("dries");
            InputData("drink"); InputData("drive"); InputData("drouge"); InputData("dropper"); InputData("drown");
            InputData("drudge"); InputData("druggist"); InputData("drunk"); InputData("drumstick"); InputData("dryer");
            InputData("dubious"); InputData("duffer"); InputData("dugout"); InputData("dungeon"); InputData("durian");
            InputData("during"); InputData("dutch"); InputData("dusky"); InputData("dumvriate"); InputData("dewller");
            InputData("dwelt"); InputData("dwindle"); InputData("dying"); InputData("dynamo"); InputData("dynamite");
            InputData("dynastic"); InputData("dynasty"); InputData("dysentery"); InputData("duplication"); InputData("dugout");
            InputData("dustpan"); InputData("dustproof"); InputData("dyspepsia"); InputData("dyspeptic"); InputData("dystrophy");

            InputData("eager"); InputData("eagle"); InputData("eardrum"); InputData("early"); InputData("earnest");
            InputData("earth"); InputData("earthquake"); InputData("easter"); InputData("ebony"); InputData("eccentric");
            InputData("echelon"); InputData("eclipse"); InputData("ecology"); InputData("economic"); InputData("ecstasy");
            InputData("edible"); InputData("edify"); InputData("editor"); InputData("educate"); InputData("eerie");
            InputData("effect"); InputData("efficacy"); InputData("efficiency"); InputData("effort"); InputData("effusive");
            InputData("eggplant"); InputData("egoist"); InputData("egypt"); InputData("eighth"); InputData("eject");
            InputData("elaborate"); InputData("elastic"); InputData("elate"); InputData("elbow"); InputData("elder");
            InputData("electric"); InputData("elegy"); InputData("electrode"); InputData("elegant"); InputData("elephant");
            InputData("elevate"); InputData("eliminate"); InputData("elite"); InputData("elixir"); InputData("ellipse");
            InputData("eloquent"); InputData("eludicate"); InputData("emanate"); InputData("embalm"); InputData("embarrass");
            // 1200
            InputData("embed"); InputData("ember"); InputData("emblem"); InputData("embryo"); InputData("emerald");
            InputData("emotion"); InputData("empire"); InputData("employ"); InputData("emporium"); InputData("empower");
            InputData("empty"); InputData("enable"); InputData("enamel"); InputData("encamp"); InputData("enchant");
            InputData("enclave"); InputData("enclose"); InputData("encompass"); InputData("encounter"); InputData("endanger");
            InputData("endear"); InputData("endeavor"); InputData("endorse"); InputData("endurable"); InputData("enemy");
            InputData("enforce"); InputData("energy"); InputData("engage"); InputData("engine"); InputData("engineering");
            InputData("engraver"); InputData("engross"); InputData("enigma"); InputData("enjoy"); InputData("enlarge");
            InputData("ennui"); InputData("enough"); InputData("enrol"); InputData("ensue"); InputData("enter");
            InputData("entertain"); InputData("entertainment"); InputData("entice"); InputData("entire"); InputData("entity");
            InputData("entrepreneur"); InputData("entrust"); InputData("entry"); InputData("envelop"); InputData("envied");

            InputData("envision"); InputData("enzyme"); InputData("epicure"); InputData("epidermis"); InputData("epigraphy");
            InputData("epilogue"); InputData("epistle"); InputData("epitome"); InputData("epoch"); InputData("equal");
            InputData("equestrian"); InputData("equip"); InputData("equipment"); InputData("equity"); InputData("eraser");
            InputData("erode"); InputData("erosion"); InputData("errand"); InputData("eruption"); InputData("escalate");
            InputData("escape"); InputData("escapist"); InputData("esophagus"); InputData("esquire"); InputData("establish");
            InputData("estate"); InputData("esthetic"); InputData("etcetera"); InputData("ether"); InputData("ethnic");
            InputData("ethos"); InputData("europe"); InputData("evacuate"); InputData("evade"); InputData("evaluate");
            InputData("evangelism"); InputData("evasive"); InputData("event"); InputData("eventual"); InputData("every");
            InputData("evidence"); InputData("evoke"); InputData("evolve"); InputData("exaggerate"); InputData("exalt");
            InputData("example"); InputData("exceed"); InputData("excel"); InputData("excellent"); InputData("excelsior");
            // 1300
            InputData("exchange"); InputData("exision"); InputData("excite"); InputData("exclude"); InputData("excommunicate");
            InputData("excuse"); InputData("execute"); InputData("exemplify"); InputData("excercise"); InputData("exhale");
            InputData("exhaustion"); InputData("exhibit"); InputData("exhibition"); InputData("exile"); InputData("existent");
            InputData("exorcise"); InputData("exotic"); InputData("expand"); InputData("expansion"); InputData("expect");
            InputData("expectation"); InputData("expel"); InputData("expense"); InputData("expensive"); InputData("experience");
            InputData("explore"); InputData("exploit"); InputData("explosive"); InputData("exposition"); InputData("exposure");
            InputData("express"); InputData("exquisite"); InputData("extension"); InputData("exterior"); InputData("external");
            InputData("extinct"); InputData("extinguisher"); InputData("extort"); InputData("extra"); InputData("extract");
            InputData("extradition"); InputData("extraterritoriality"); InputData("extravagant"); InputData("extremity"); InputData("exude");
            InputData("eyeball"); InputData("eyelash"); InputData("eyesore"); InputData("eyetooth"); InputData("eyewitness");

            InputData("fable"); InputData("fabric"); InputData("fabulous"); InputData("facade"); InputData("facecloth"); // F
            InputData("facedown"); InputData("facial"); InputData("facility"); InputData("faction"); InputData("factor");
            InputData("faculty"); InputData("farenheit"); InputData("faggot"); InputData("failure"); InputData("faint");
            InputData("fairy"); InputData("faith"); InputData("faker"); InputData("falcon"); InputData("fallout");
            InputData("false"); InputData("falter"); InputData("family"); InputData("famed"); InputData("familiar");
            InputData("family"); InputData("famous"); InputData("fanatic"); InputData("fancy"); InputData("fanfare");
            InputData("fantasy"); InputData("faraway"); InputData("farce"); InputData("farm"); InputData("farmhouse");
            InputData("fascination"); InputData("fashionable"); InputData("fasten"); InputData("fatal"); InputData("fated");
            InputData("father"); InputData("fathom"); InputData("fatigue"); InputData("faucet"); InputData("favor");
            InputData("favorable"); InputData("fearless"); InputData("feature"); InputData("federal"); InputData("feeble");
            // 1400
            InputData("feedback"); InputData("feeder"); InputData("feeler"); InputData("fellow"); InputData("female");
            InputData("feminine"); InputData("fencer"); InputData("ferocious"); InputData("fenner"); InputData("ferment");
            InputData("ferris"); InputData("ferry"); InputData("fertilization"); InputData("fetch"); InputData("fetal");
            InputData("fervor"); InputData("festive"); InputData("fetch"); InputData("fetish"); InputData("fever");
            InputData("fiancee"); InputData("fiber"); InputData("fibula"); InputData("fiddle"); InputData("fidget");
            InputData("field"); InputData("fiend"); InputData("fierce"); InputData("fiesta"); InputData("fight");
            InputData("fighter"); InputData("figure"); InputData("filet"); InputData("filler"); InputData("filipino");
            InputData("filter"); InputData("filth"); InputData("filthy"); InputData("finance"); InputData("financier");
            InputData("finder"); InputData("finery"); InputData("finger"); InputData("finish"); InputData("finland");
            InputData("firearm"); InputData("fireman"); InputData("firecracker"); InputData("fireworks"); InputData("first");

            InputData("fiscal"); InputData("fishery"); InputData("fissure"); InputData("fistula"); InputData("fitful");
            InputData("fitter"); InputData("fiver"); InputData("fixation"); InputData("fixer"); InputData("fixture");
            InputData("flaccid"); InputData("flagpole"); InputData("flail"); InputData("flame"); InputData("flameproof");
            InputData("flannel"); InputData("flapper"); InputData("flappy"); InputData("flare"); InputData("flash");
            InputData("flashcard"); InputData("flashlight"); InputData("flatiron"); InputData("flatter"); InputData("flavor");
            InputData("flawless"); InputData("fledging"); InputData("fleece"); InputData("flesh"); InputData("flexible");
            InputData("flick"); InputData("flies"); InputData("flight"); InputData("flighty"); InputData("fling");
            InputData("flint"); InputData("flirt"); InputData("float"); InputData("flock"); InputData("flood");
            InputData("floor"); InputData("floppy"); InputData("flora"); InputData("florist"); InputData("flotsam");
            InputData("flour"); InputData("flourish"); InputData("flower"); InputData("flown"); InputData("fluid");
            // 1500
            InputData("flush"); InputData("flute"); InputData("flyer"); InputData("flypaper"); InputData("focus");
            InputData("fodder"); InputData("foggy"); InputData("foist"); InputData("foliage"); InputData("folio");
            InputData("folklore"); InputData("follow"); InputData("follower"); InputData("folly"); InputData("foment");
            InputData("fondness"); InputData("foolish"); InputData("footage"); InputData("football"); InputData("footloose");
            InputData("footprint"); InputData("foppish"); InputData("forbid"); InputData("force"); InputData("forebode");
            InputData("forecastle"); InputData("foreclose"); InputData("forefather"); InputData("foreign"); InputData("foreman");
            InputData("foresaw"); InputData("forever"); InputData("forfeit"); InputData("forge"); InputData("forget");
            InputData("forgive"); InputData("forgo"); InputData("forgot"); InputData("forkful"); InputData("forlorn");
            InputData("formal"); InputData("formality"); InputData("formation"); InputData("formic"); InputData("formula");
            InputData("forsake"); InputData("forsaken"); InputData("forswear"); InputData("forthcoming"); InputData("fortress");

            InputData("fortify"); InputData("fortune"); InputData("forum"); InputData("fossil"); InputData("foster");
            InputData("found"); InputData("founder"); InputData("foundry"); InputData("foursquare"); InputData("fraction");
            InputData("fragile"); InputData("fragment"); InputData("frail"); InputData("frame"); InputData("france");
            InputData("frantic"); InputData("fraud"); InputData("freak"); InputData("freed"); InputData("freedom");
            InputData("freeze"); InputData("french"); InputData("frenzy"); InputData("frequency"); InputData("fresh");
            InputData("freshen"); InputData("friction"); InputData("friendly"); InputData("fries"); InputData("fright");
            InputData("frigid"); InputData("fringe"); InputData("frisky"); InputData("frizzle"); InputData("front");
            InputData("frontal"); InputData("frosh"); InputData("frost"); InputData("frostbite"); InputData("frown");
            InputData("frustration"); InputData("fryer"); InputData("frypan"); InputData("fugitive"); InputData("fugue");
            InputData("fumble"); InputData("function"); InputData("funny"); InputData("future"); InputData("fusion");
            // 1600
            InputData("gabardine"); InputData("gadfly"); InputData("gaffe"); InputData("gainful"); InputData("galaxy");
            InputData("gallant"); InputData("gallery"); InputData("gallon"); InputData("galvanize"); InputData("gambit");
            InputData("gamble"); InputData("gamma"); InputData("gander"); InputData("gangling"); InputData("gangplank");
            InputData("gangster"); InputData("garage"); InputData("garbage"); InputData("garden"); InputData("garment");
            InputData("garnish"); InputData("garret"); InputData("gaseous"); InputData("gastronomic"); InputData("gateway");
            InputData("gather"); InputData("gauche"); InputData("gauntlet"); InputData("gavel"); InputData("gazelle");
            InputData("gecko"); InputData("geese"); InputData("geiger"); InputData("gemination"); InputData("gemini");
            InputData("gender"); InputData("general"); InputData("generate"); InputData("generation"); InputData("generous");
            InputData("genetics"); InputData("genius"); InputData("gentle"); InputData("genuine"); InputData("geography");
            InputData("geometry"); InputData("german"); InputData("gesture"); InputData("geyser"); InputData("ghastly");

            InputData("ghetto"); InputData("ghost"); InputData("ghoul"); InputData("giant"); InputData("gibberish");
            InputData("giddy"); InputData("gigantic"); InputData("giggle"); InputData("gimmick"); InputData("ginger");
            InputData("girlish"); InputData("glacial"); InputData("glade"); InputData("gladiator"); InputData("glamour");
            InputData("glance"); InputData("gland"); InputData("glare"); InputData("glass"); InputData("gleam");
            InputData("glide"); InputData("glimpse"); InputData("glitter"); InputData("gloom"); InputData("glorious");
            InputData("glossy"); InputData("glove"); InputData("gluten"); InputData("gnash"); InputData("gnome");
            InputData("gobble"); InputData("goblet"); InputData("goddess"); InputData("godlike"); InputData("golden");
            InputData("goner"); InputData("goody"); InputData("goose"); InputData("gospel"); InputData("gorilla");
            InputData("goosebump"); InputData("gorge"); InputData("gossip"); InputData("gouge"); InputData("gourd");
            InputData("government"); InputData("grace"); InputData("grader"); InputData("graduate"); InputData("grand");
            // 1700
            InputData("grandfather"); InputData("grandmother"); InputData("grater"); InputData("grateful"); InputData("gratify");
            InputData("grave"); InputData("graveyard"); InputData("gravity"); InputData("greasy"); InputData("great");
            InputData("greedy"); InputData("greek"); InputData("green"); InputData("greyhound"); InputData("griddle");
            InputData("grief"); InputData("grind"); InputData("grizzly"); InputData("groan"); InputData("groom");
            InputData("groovy"); InputData("grouch"); InputData("ground"); InputData("group"); InputData("grove");
            InputData("growl"); InputData("gruesome"); InputData("grunt"); InputData("guarantee"); InputData("guard");
            InputData("guess"); InputData("guide"); InputData("guild"); InputData("guilty"); InputData("guinea");
            InputData("guitar"); InputData("gullet"); InputData("gummy"); InputData("gunboat"); InputData("gunfight");
            InputData("gunsmith"); InputData("gushy"); InputData("gusty"); InputData("gutter"); InputData("guttersnipe");
            InputData("guzzle"); InputData("gymnasium"); InputData("gypsum"); InputData("gypsy"); InputData("gyroscope");

            InputData("habit"); InputData("habitat"); InputData("hacksaw"); InputData("haggle"); InputData("hailstorm"); // F
            InputData("hairdo"); InputData("hairdresser"); InputData("hairy"); InputData("halcyon"); InputData("halibut");
            InputData("hallow"); InputData("halter"); InputData("hammer"); InputData("hamster"); InputData("handbook");
            InputData("handicap"); InputData("handicraft"); InputData("handle"); InputData("handshake"); InputData("handy");
            InputData("hangar"); InputData("hangman"); InputData("hangover"); InputData("happen"); InputData("happy");
            InputData("harbor"); InputData("harassment"); InputData("hardware"); InputData("hardtop"); InputData("harem");
            InputData("harmless"); InputData("harmonica"); InputData("harmony"); InputData("harness"); InputData("harrow");
            InputData("harvest"); InputData("hashish"); InputData("hasty"); InputData("hatchet"); InputData("haunch");
            InputData("haunt"); InputData("haven"); InputData("hawker"); InputData("hawser"); InputData("haywire");
            InputData("hazelnut"); InputData("headdress"); InputData("headphone"); InputData("headquarters"); InputData("headstrong");
            // 1800
            InputData("health"); InputData("hearer"); InputData("heart"); InputData("heartbreak"); InputData("hearten");
            InputData("heater"); InputData("heaven"); InputData("heavenly"); InputData("hebrew"); InputData("heckler");
            InputData("hectic"); InputData("hectograph"); InputData("hedgehog"); InputData("hedonism"); InputData("height");
            InputData("heiress"); InputData("helicopter"); InputData("helium"); InputData("hellcat"); InputData("hello");
            InputData("helper"); InputData("hemisphere"); InputData("hemorrhage"); InputData("henpeck"); InputData("hepatitis");
            InputData("heptagon"); InputData("herald"); InputData("hereby"); InputData("heretic"); InputData("heritage");
            InputData("hesitate"); InputData("heterodox"); InputData("hexagon"); InputData("hibernate"); InputData("hidden");
            InputData("hideaway"); InputData("hierarchy"); InputData("highlands"); InputData("highway"); InputData("hiker");
            InputData("hinder"); InputData("hindi"); InputData("hindu"); InputData("hippie"); InputData("hippotamus");
            InputData("historic"); InputData("history"); InputData("hitch"); InputData("hitter"); InputData("hoard");

            InputData("hoax"); InputData("hobgoblin"); InputData("hockey"); InputData("hoist"); InputData("hokum");
            InputData("holder"); InputData("holdup"); InputData("holland"); InputData("hollow"); InputData("holly");
            InputData("homage"); InputData("homeless"); InputData("homesick"); InputData("hometown"); InputData("homey");
            InputData("honest"); InputData("honey"); InputData("honor"); InputData("honorable"); InputData("honorary");
            InputData("hookey"); InputData("hooves"); InputData("hopeful"); InputData("hopper"); InputData("horde");
            InputData("horizon"); InputData("horoscope"); InputData("hornet"); InputData("horrify"); InputData("horror");
            InputData("horse"); InputData("horseman"); InputData("hospital"); InputData("hostility"); InputData("hourglass");
            InputData("house"); InputData("houseboat"); InputData("housefly"); InputData("housekeeping"); InputData("hover");
            InputData("however"); InputData("howler"); InputData("hubhub"); InputData("huffy"); InputData("hulking");
            InputData("humanism"); InputData("humble"); InputData("humbug"); InputData("humiliate"); InputData("humidity");
            // 1900
            InputData("humor"); InputData("humorous"); InputData("humpback"); InputData("hunch"); InputData("hundreth");
            InputData("hungry"); InputData("hunker"); InputData("hunter"); InputData("hurdler"); InputData("hurricane");
            InputData("hurry"); InputData("hurtle"); InputData("husband"); InputData("husky"); InputData("hybrid");
            InputData("hygienic"); InputData("hymnal"); InputData("hyperactive"); InputData("hypnosis"); InputData("hypercritical");
            InputData("hypocrite"); InputData("hypocondria"); InputData("hypothesis"); InputData("hypothetical"); InputData("hysteria");
            InputData("iceberg"); InputData("icebreaker"); InputData("icicle"); InputData("ideal"); InputData("idealism"); // I
            InputData("identification"); InputData("identified"); InputData("identity"); InputData("ideogram"); InputData("ideology");
            InputData("idiomaatic"); InputData("idiosyncrasy"); InputData("idleness"); InputData("idler"); InputData("idolize");
            InputData("igloo"); InputData("igneous"); InputData("ignite"); InputData("ignoble"); InputData("ignorance");
            InputData("ignore"); InputData("iguana"); InputData("ilium"); InputData("illegal"); InputData("illegible");

            InputData("illiterate"); InputData("illumination"); InputData("illusion"); InputData("illustrate"); InputData("image");
            InputData("imaginable"); InputData("imagine"); InputData("imbecile"); InputData("imbibe"); InputData("imbroglio");
            InputData("imitate"); InputData("imitation"); InputData("immature"); InputData("immaterial"); InputData("immediate");
            InputData("immense"); InputData("immigrant"); InputData("immoderate"); InputData("immodest"); InputData("immobilize");
            InputData("impart"); InputData("impassable"); InputData("impeach"); InputData("impatient"); InputData("impel");
            InputData("imperative"); InputData("imperfection"); InputData("imperial"); InputData("impenetrable"); InputData("impermanent");
            InputData("impetigo"); InputData("impetuous"); InputData("implant"); InputData("impious"); InputData("impolite");
            InputData("import"); InputData("important"); InputData("importer"); InputData("imposition"); InputData("impossible");
            InputData("impostor"); InputData("impotent"); InputData("impound"); InputData("impracticable"); InputData("impress");
            InputData("imprison"); InputData("impromptu"); InputData("improper"); InputData("improve"); InputData("improvise");
            // 2000
            InputData("impure"); InputData("inactive"); InputData("inadequate"); InputData("inane"); InputData("innapreciative");
            InputData("inaugral"); InputData("inattention"); InputData("inboard"); InputData("inborn"); InputData("incapable");
            InputData("incapacitate"); InputData("incense"); InputData("incarnate"); InputData("incautious"); InputData("incest");
            InputData("incipent"); InputData("incite"); InputData("inclination"); InputData("include"); InputData("inclusive");
            InputData("incoming"); InputData("incommensurate"); InputData("incomparable"); InputData("incompetence"); InputData("inconceivable");
            InputData("inconsiderable"); InputData("inconvenience"); InputData("incorporation"); InputData("incredible"); InputData("incredulity");
            InputData("incrust"); InputData("incubation"); InputData("incurable"); InputData("indebted"); InputData("indecency");
            InputData("indefinite"); InputData("independent"); InputData("indescribable"); InputData("indestructible"); InputData("indirect");
            InputData("indispensable"); InputData("individual"); InputData("indubitable"); InputData("induce"); InputData("inductive");
            InputData("indulge"); InputData("industrialize"); InputData("industrious"); InputData("inedible"); InputData("inefficient");

            InputData("inept"); InputData("inequality"); InputData("inexperienced"); InputData("inexpert"); InputData("infamous");
            InputData("infantry"); InputData("infatuation"); InputData("inferior"); InputData("inferno"); InputData("infest");
            InputData("infiltrate"); InputData("infinite"); InputData("infinity"); InputData("inflammable"); InputData("inflate");
            InputData("inflect"); InputData("inflexible"); InputData("inflict"); InputData("influence"); InputData("influx");
            InputData("informal"); InputData("informant"); InputData("infomration"); InputData("infra"); InputData("infuse");
            InputData("ingenuity"); InputData("ingot"); InputData("ingrate"); InputData("ingrown"); InputData("inhabitable");
            InputData("inherit"); InputData("inhuman"); InputData("inimical"); InputData("initate"); InputData("initiation");
            InputData("initiate"); InputData("injector"); InputData("injure"); InputData("inkpad"); InputData("inland");
            InputData("inmost"); InputData("innermost"); InputData("innocent"); InputData("innovation"); InputData("inoperable");
            InputData("inquire"); InputData("insane"); InputData("inscribe"); InputData("insect"); InputData("insecure");
            // 2100
            InputData("insert"); InputData("inset"); InputData("insider"); InputData("insignia"); InputData("insincere");
            InputData("insolence"); InputData("insist"); InputData("insomnia"); InputData("inspect"); InputData("inspire");
            InputData("installer"); InputData("instance"); InputData("instant"); InputData("instead"); InputData("institute");
            InputData("instruction"); InputData("instructor"); InputData("instrumental"); InputData("insubordinate"); InputData("insufficient");
            InputData("insulator"); InputData("insurance"); InputData("insurgent"); InputData("insurrection"); InputData("intake");
            InputData("integer"); InputData("integral"); InputData("integration"); InputData("intellectual"); InputData("intelligence");
            InputData("intend"); InputData("intense"); InputData("intensify"); InputData("intention"); InputData("interact");
            InputData("intercede"); InputData("interceptor"); InputData("intercity"); InputData("intercom"); InputData("intercourse");
            InputData("intercultural"); InputData("interest"); InputData("interior"); InputData("interlace"); InputData("interlock");
            InputData("interlude"); InputData("intermediate"); InputData("intermezzo"); InputData("internal"); InputData("international");

            InputData("interpersonal"); InputData("interpretation"); InputData("interrogation"); InputData("interruption"); InputData("intersection");
            InputData("interstate"); InputData("interval"); InputData("interview"); InputData("intimidate"); InputData("intolerable");
            InputData("intone"); InputData("intoxication"); InputData("intrepid"); InputData("intrigue"); InputData("introduce");
            InputData("introspection"); InputData("introvert"); InputData("intruder"); InputData("intuition"); InputData("inure");
            InputData("invade"); InputData("invasion"); InputData("invent"); InputData("inventory"); InputData("invert");
            InputData("investor"); InputData("invidible"); InputData("invite"); InputData("invoke"); InputData("involve");
            InputData("inward"); InputData("iodine"); InputData("ionic"); InputData("irascible"); InputData("ironic");
            InputData("irradiation"); InputData("irrational"); InputData("irrecoverable"); InputData("irregular"); InputData("irrelevant");
            InputData("irremovable"); InputData("irresponsible"); InputData("irreverent"); InputData("irreversible"); InputData("irritate");
            InputData("islamic"); InputData("island"); InputData("isobar"); InputData("isolate"); InputData("itinerary");
            // 2200
            InputData("jabber"); InputData("jackal"); InputData("jacket"); InputData("jackfruit"); InputData("jackhammer"); // J
            InputData("jackpot"); InputData("jagged"); InputData("jaguar"); InputData("jailbreak"); InputData("jalopy");
            InputData("jamaica"); InputData("jamproof"); InputData("january"); InputData("japanese"); InputData("jargon");
            InputData("jasmin"); InputData("jaunty"); InputData("javanese"); InputData("jaycee"); InputData("jazzy");
            InputData("jealous"); InputData("jehovah"); InputData("jellybean"); InputData("jeoparadise"); InputData("jeopardy");
            InputData("jerky"); InputData("jerry"); InputData("jersey"); InputData("jester"); InputData("jetsam");
            InputData("jewel"); InputData("jewish"); InputData("jiffy"); InputData("jigsaw"); InputData("jiggle");
            InputData("jingle"); InputData("jitters"); InputData("jobholder"); InputData("johnny"); InputData("joiner");
            InputData("joint"); InputData("joker"); InputData("jolly"); InputData("jostle"); InputData("journal");
            InputData("jovial"); InputData("joyful"); InputData("judge"); InputData("judgement"); InputData("judicial");

            InputData("juggernaut"); InputData("juggle"); InputData("juice"); InputData("juicy"); InputData("jujitsu");
            InputData("jumbo"); InputData("jumper"); InputData("jumpy"); InputData("junction"); InputData("juncture");
            InputData("junket"); InputData("junkie"); InputData("junkyard"); InputData("jupiter"); InputData("juridical");
            InputData("juror"); InputData("justice"); InputData("justified"); InputData("justify"); InputData("juvenille");
            InputData("kaiser"); InputData("kaleidoscope"); InputData("kangaroo"); InputData("kaolin"); InputData("kayak"); // K
            InputData("keenness"); InputData("keeper"); InputData("keepsake"); InputData("kerplunk"); InputData("kennel");
            InputData("kettledrum"); InputData("keyboard"); InputData("keystone"); InputData("kibitz"); InputData("kicker");
            InputData("kickoff"); InputData("kiddy"); InputData("kidnap"); InputData("killer"); InputData("kilogram");
            InputData("kimono"); InputData("kindergarten"); InputData("kindle"); InputData("kingdom"); InputData("kingly");
            InputData("kindness"); InputData("kingship"); InputData("kingpin"); InputData("kinsman"); InputData("kisser");
            // 2300
            InputData("kitbag"); InputData("kitchen"); InputData("kitten"); InputData("kitty"); InputData("klaxon");
            InputData("kleptomaniac"); InputData("knack"); InputData("knave"); InputData("kneel"); InputData("knife");
            InputData("knight"); InputData("knighthood"); InputData("knock"); InputData("knockout"); InputData("knoll");
            InputData("knothole"); InputData("knotty"); InputData("knowledge"); InputData("known"); InputData("knuckle");
            InputData("knucklebone"); InputData("knucklehead"); InputData("kodak"); InputData("kooky"); InputData("korean");
            InputData("label"); InputData("labial"); InputData("labor"); InputData("laboratory"); InputData("labyrinth"); // L
            InputData("lacerate"); InputData("lackey"); InputData("laconic"); InputData("lactation"); InputData("lacrosse");
            InputData("ladder"); InputData("ladies"); InputData("ladybug"); InputData("lager"); InputData("laggard");
            InputData("lagoon"); InputData("lakeside"); InputData("lambaste"); InputData("lament"); InputData("laminated");
            InputData("lamplight"); InputData("lance"); InputData("landlord"); InputData("landlubber"); InputData("landmark");

            InputData("landscape"); InputData("landslide"); InputData("landward"); InputData("languish"); InputData("lantern");
            InputData("laotian"); InputData("lapboard"); InputData("lapful"); InputData("lapse"); InputData("larceny");
            InputData("larder"); InputData("large"); InputData("lariat"); InputData("larva"); InputData("laryngeal");
            InputData("lasstitude"); InputData("lasso"); InputData("latch"); InputData("latchstring"); InputData("latecomer");
            InputData("lateness"); InputData("latent"); InputData("lateral"); InputData("lather"); InputData("latter");
            InputData("lattice"); InputData("laudable"); InputData("laudatory"); InputData("laugh"); InputData("launch");
            InputData("launder"); InputData("laundry"); InputData("laurel"); InputData("lawbook"); InputData("lawbreaker");
            InputData("lawmaker"); InputData("lawsuit"); InputData("lawyer"); InputData("laxity"); InputData("layaway");
            InputData("layette"); InputData("layout"); InputData("laziness"); InputData("lazybones"); InputData("leaden");
            InputData("leader"); InputData("leadership"); InputData("leaflet"); InputData("league"); InputData("leakproof");
            // 2400
            InputData("leapfrog"); InputData("learn"); InputData("leathery"); InputData("leaven"); InputData("leafes");
            InputData("lecher"); InputData("lecture"); InputData("letcher"); InputData("leftover"); InputData("lefty");
            InputData("legacy"); InputData("legality"); InputData("legendary"); InputData("legion"); InputData("legitimacy");
            InputData("leisured"); InputData("lemonade"); InputData("length"); InputData("leninent"); InputData("lesion");
            InputData("lessor"); InputData("lethal"); InputData("letter"); InputData("level"); InputData("lewd");
            InputData("libelious"); InputData("liberty"); InputData("license"); InputData("licorice"); InputData("lieutenant");
            InputData("lifeguard"); InputData("ligament"); InputData("light"); InputData("lighten"); InputData("likable");
            InputData("likely"); InputData("lilac"); InputData("limit"); InputData("limpid"); InputData("lineal");
            InputData("linen"); InputData("lingerie"); InputData("linguistic"); InputData("liquid"); InputData("listen");
            InputData("literaly"); InputData("lithograph"); InputData("litter"); InputData("little"); InputData("lively");

            InputData("liver"); InputData("lizzard"); InputData("loafer"); InputData("loathe"); InputData("local");
            InputData("location"); InputData("locker"); InputData("lockup"); InputData("lofty"); InputData("logger");
            InputData("loiter"); InputData("loner"); InputData("longevity"); InputData("longitude"); InputData("looker");
            InputData("loose"); InputData("looter"); InputData("loser"); InputData("lottery"); InputData("loudmouthed");
            InputData("lovebird"); InputData("lover"); InputData("lovesick"); InputData("loyalty"); InputData("lucid");
            InputData("ludicrous"); InputData("lullaby"); InputData("lumberjack"); InputData("luminous"); InputData("lunacy");
            InputData("lunar"); InputData("lunatic"); InputData("luncheon"); InputData("lurch"); InputData("lurid");
            InputData("lust"); InputData("lustful"); InputData("luxury"); InputData("luxurious"); InputData("lyric");
            InputData("macadam"); InputData("machination"); InputData("machine"); InputData("macron"); InputData("madame"); // M
            InputData("magazine"); InputData("maestro"); InputData("magician"); InputData("magnet"); InputData("magnify");
            // 2500
            InputData("magnitude"); InputData("maiden"); InputData("mailbox"); InputData("mainspring"); InputData("majesty");
            InputData("major"); InputData("maker"); InputData("malaise"); InputData("malfunction"); InputData("malicious");
            InputData("mallet"); InputData("mammal"); InputData("mammoth"); InputData("manage"); InputData("mandatory");
            InputData("mandolin"); InputData("manhole"); InputData("maniac"); InputData("manifest"); InputData("manila");
            InputData("mango"); InputData("mangosteen"); InputData("mangrove"); InputData("manner"); InputData("marcher");
            InputData("marginal"); InputData("martial"); InputData("market"); InputData("marriage"); InputData("maroon");
            InputData("marshal"); InputData("martyr"); InputData("masculine"); InputData("masher"); InputData("masochist");
            InputData("masquerade"); InputData("massacre"); InputData("massive"); InputData("mastery"); InputData("match");
            InputData("material"); InputData("mathematics"); InputData("matriculation"); InputData("matron"); InputData("mausoleum");
            InputData("maximum"); InputData("mayday"); InputData("mayonnaise"); InputData("mealtime"); InputData("meaningless");

            InputData("measure"); InputData("mechanic"); InputData("medal"); InputData("medicament"); InputData("meditation");
            InputData("megalomania"); InputData("megaphone"); InputData("melancholy"); InputData("melody"); InputData("melon");
            InputData("member"); InputData("memoir"); InputData("memorial"); InputData("mendacity"); InputData("menial");
            InputData("mental"); InputData("mercury"); InputData("mercy"); InputData("merit"); InputData("mermaid");
            InputData("message"); InputData("metal"); InputData("meter"); InputData("method"); InputData("metrics");
            InputData("metronome"); InputData("mettle"); InputData("microscope"); InputData("middle"); InputData("midnight");
            InputData("migrate"); InputData("mildness"); InputData("military"); InputData("million"); InputData("mimic");
            InputData("mincemeat"); InputData("mindful"); InputData("miner"); InputData("mineral"); InputData("minister");
            InputData("minor"); InputData("minute"); InputData("miracle"); InputData("mirror"); InputData("miscarry");
            InputData("miscount"); InputData("mischief"); InputData("misfire"); InputData("mislead"); InputData("misname");
            // 2600
            InputData("missionary"); InputData("misspeak");  InputData("mistake"); InputData("mister"); InputData("mistreatment");
            InputData("mistrial"); InputData("mitigation"); InputData("mixture"); InputData("mobile"); InputData("mobilize");
            InputData("model"); InputData("modern"); InputData("modest"); InputData("modification"); InputData("modify");
            InputData("molecule"); InputData("molten"); InputData("momentum"); InputData("money"); InputData("monitor");
            InputData("monochrome"); InputData("monkey"); InputData("monster"); InputData("monument"); InputData("moody");
            InputData("monument"); InputData("monopoly"); InputData("mouse"); InputData("morass"); InputData("moreover");
            InputData("morning"); InputData("moron"); InputData("morphology"); InputData("mortal"); InputData("mortar");
            InputData("mosquito"); InputData("mosque"); InputData("mother"); InputData("motion"); InputData("motive");
            InputData("motorbike"); InputData("mound"); InputData("mount"); InputData("mouth"); InputData("movable");
            InputData("mover"); InputData("movie"); InputData("mower"); InputData("mucilage"); InputData("mulch");

            InputData("multicolored"); InputData("multilevel"); InputData("multiplication"); InputData("mumble"); InputData("murmur");
            InputData("muscular"); InputData("muslim"); InputData("mussy"); InputData("muster"); InputData("musty");
            InputData("mutation"); InputData("mutiny"); InputData("mutual"); InputData("mustic"); InputData("mythical");
            InputData("naive"); InputData("name"); InputData("narrow"); InputData("nascent"); InputData("nastiness"); // N
            InputData("native"); InputData("natty"); InputData("natural"); InputData("nature"); InputData("naval");
            InputData("navigator"); InputData("nearby"); InputData("necessary"); InputData("necklace"); InputData("nectar");
            InputData("needle"); InputData("needs"); InputData("negative"); InputData("negotiate"); InputData("neighborhood");
            InputData("neither"); InputData("nepotism"); InputData("nephew"); InputData("nestle"); InputData("nettle");
            InputData("neurotic"); InputData("neutral"); InputData("nerve"); InputData("nervous"); InputData("network");
            InputData("neuter"); InputData("nevermore"); InputData("newcomer"); InputData("newsletter"); InputData("nibble");
            // 2700
            InputData("nickname"); InputData("night"); InputData("nightmare"); InputData("nightstick"); InputData("nimble");
            InputData("nitrogen"); InputData("noble"); InputData("nocturnal"); InputData("noise"); InputData("noisy");
            InputData("nomad"); InputData("nomination"); InputData("nonce"); InputData("nondescript"); InputData("nonprofit");
            InputData("nonsmoker"); InputData("noon"); InputData("normal"); InputData("north"); InputData("norwegian");
            InputData("nostril"); InputData("notable"); InputData("notch"); InputData("nothing"); InputData("notion");
            InputData("notorious"); InputData("nought"); InputData("nourish"); InputData("novice"); InputData("nowhere");
            InputData("nuance"); InputData("nuclear"); InputData("nucleus"); InputData("nudge"); InputData("nuisance");
            InputData("null"); InputData("numb"); InputData("number"); InputData("nupital"); InputData("nurse");
            InputData("oaken"); InputData("oarsman"); InputData("obelisk"); InputData("object"); InputData("objection"); // O
            InputData("obligate"); InputData("oblivion"); InputData("obscene"); InputData("observant"); InputData("observatory");

            InputData("obstruction"); InputData("obtain"); InputData("obvious"); InputData("occasional"); InputData("occlusion");
            InputData("occult"); InputData("occupation"); InputData("occupy"); InputData("occur"); InputData("ocean");
            InputData("octave"); InputData("october"); InputData("oddity"); InputData("odyssey"); InputData("offend");
            InputData("offense"); InputData("offer"); InputData("office"); InputData("official"); InputData("offset");
            InputData("often"); InputData("oiler"); InputData("olden"); InputData("olive"); InputData("olympic");
            InputData("omnibus"); InputData("omnivorous"); InputData("oncoming"); InputData("onion"); InputData("ongoing");
            InputData("onrush"); InputData("onslaught"); InputData("oomph"); InputData("opaque"); InputData("opener");
            InputData("opera"); InputData("operator"); InputData("opinion"); InputData("opportunity"); InputData("opposite");
            InputData("opposition"); InputData("optical"); InputData("optimal"); InputData("optional"); InputData("orange");
            InputData("orchestra"); InputData("orchard"); InputData("orbit"); InputData("order"); InputData("ordain");
            // 2800
            InputData("ordinal"); InputData("ordinate"); InputData("oregano"); InputData("organ"); InputData("organize");
            InputData("oriental"); InputData("original"); InputData("ornament"); InputData("ornate"); InputData("orphan");
            InputData("orthodox"); InputData("osmosis"); InputData("ostrich"); InputData("other"); InputData("otherwise");
            InputData("ought"); InputData("ouster"); InputData("outburst"); InputData("outdoor"); InputData("outlet");
            InputData("outline"); InputData("outmatch"); InputData("outpost"); InputData("outrage"); InputData("outrageous");
            InputData("outset"); InputData("outrun"); InputData("outside"); InputData("outskirts"); InputData("outward");
            InputData("outwork"); InputData("overactive"); InputData("overage"); InputData("overate"); InputData("overconfidence");
            InputData("overcrowd"); InputData("overdo"); InputData("overdraft"); InputData("overeat"); InputData("overestimate");
            InputData("overflow"); InputData("overhaul"); InputData("overheat"); InputData("overlook"); InputData("overlord");
            InputData("overplay"); InputData("override"); InputData("overrun"); InputData("oversee"); InputData("overslept");

            InputData("overstep"); InputData("overturn"); InputData("overweight"); InputData("overwork"); InputData("owner");
            InputData("oxford"); InputData("oxide"); InputData("oxtail"); InputData("oxtounge"); InputData("ozone");
            InputData("pace"); InputData("pacemaker"); InputData("pacific"); InputData("pacify"); InputData("packet"); // P
            InputData("paddle"); InputData("pagan"); InputData("pageant"); InputData("pagoda"); InputData("painful");
            InputData("painkiller"); InputData("painless"); InputData("paint"); InputData("pajamas"); InputData("palace");
            InputData("palatal"); InputData("palate"); InputData("pallor"); InputData("pallid"); InputData("palmist");
            InputData("palpable"); InputData("pamper"); InputData("pancake"); InputData("panel"); InputData("panic");
            InputData("panorama"); InputData("papacy"); InputData("papaya"); InputData("paper"); InputData("paperclip");
            InputData("parabola"); InputData("parachute"); InputData("parade"); InputData("paragon"); InputData("parallel");
            InputData("paragraph"); InputData("paralysis"); InputData("parasol"); InputData("parcel"); InputData("pardon");
            // 2900
            InputData("parent"); InputData("parer"); InputData("parish"); InputData("parley"); InputData("parlor");
            InputData("parrot"); InputData("parries"); InputData("parson"); InputData("partial"); InputData("participate");
            InputData("particle"); InputData("partition"); InputData("party"); InputData("passable"); InputData("passage");
            InputData("passion"); InputData("passionate"); InputData("passive"); InputData("password"); InputData("paste");
            InputData("pastor"); InputData("patch"); InputData("patent"); InputData("patience"); InputData("patrician");
            InputData("partiot"); InputData("patrol"); InputData("pattern"); InputData("pavilion"); InputData("pawnshop");
            InputData("payday"); InputData("peace"); InputData("peach"); InputData("peacock"); InputData("peanut");
            InputData("pebble"); InputData("pecan"); InputData("pectoral"); InputData("pedal"); InputData("pedant");
            InputData("pedicab"); InputData("peeve"); InputData("pejorative"); InputData("penal"); InputData("penalty");
            InputData("pendant"); InputData("pendulum"); InputData("pending"); InputData("penetration"); InputData("penguin");

            InputData("pennant"); InputData("pension"); InputData("pentagon"); InputData("pepper"); InputData("pepsin");
            InputData("percentage"); InputData("perception"); InputData("perch"); InputData("percussion"); InputData("perfect");
            InputData("performance"); InputData("perfume"); InputData("perhaps"); InputData("peril"); InputData("peripheral");
            InputData("permanent"); InputData("permit"); InputData("permutation"); InputData("peroxide"); InputData("perplex");
            InputData("persian"); InputData("persistence"); InputData("personal"); InputData("personality"); InputData("personnel");
            InputData("persuade"); InputData("pertain"); InputData("perusal"); InputData("pesky"); InputData("pester");
            InputData("pesticide"); InputData("petition"); InputData("petrify"); InputData("petroleum"); InputData("petty");
            InputData("phantasy"); InputData("phantom"); InputData("phalanx"); InputData("phase"); InputData("phenomena");
            InputData("pheasant"); InputData("philantrophy"); InputData("philipine"); InputData("philosophy"); InputData("phony");
            InputData("photo"); InputData("photographer"); InputData("photomap"); InputData("phrase"); InputData("phylum");
            // 3000
            InputData("physician"); InputData("piccolo"); InputData("pickaxe"); InputData("pickup"); InputData("picnic");
            InputData("picture"); InputData("pierce"); InputData("piggy"); InputData("pigment"); InputData("pilgrim");
            InputData("pillar"); InputData("pillow"); InputData("pimple"); InputData("pinch"); InputData("pinion");
            InputData("pinkish"); InputData("pipsqueak"); InputData("pirate"); InputData("pistol"); InputData("pitch");
            InputData("pitfall"); InputData("pitiful"); InputData("pixie"); InputData("place"); InputData("placement");
            InputData("plague"); InputData("plane"); InputData("planet"); InputData("plant"); InputData("plasma");
            InputData("plastic"); InputData("plateau"); InputData("platinum"); InputData("plaudits"); InputData("plausible");
            InputData("player"); InputData("playmate"); InputData("pleasant"); InputData("please"); InputData("pleat");
            InputData("pledge"); InputData("plenty"); InputData("plied"); InputData("pliers"); InputData("pluck");
            InputData("plugger"); InputData("plumb"); InputData("plunk"); InputData("plush"); InputData("pneumatic");

            InputData("poach"); InputData("pocket"); InputData("point"); InputData("poison"); InputData("poker");
            InputData("polar"); InputData("polarize"); InputData("police"); InputData("polio"); InputData("polish");
            InputData("polite"); InputData("polka"); InputData("pollen"); InputData("polytechnic"); InputData("pontoon");
            InputData("pooch"); InputData("poppy"); InputData("popular"); InputData("population"); InputData("porcupine");
            InputData("porous"); InputData("portage"); InputData("portrait"); InputData("position"); InputData("possess");
            InputData("possible"); InputData("possum"); InputData("poster"); InputData("posthole"); InputData("posture");
            InputData("potent"); InputData("potential"); InputData("potion"); InputData("potpie"); InputData("potter");
            InputData("pottery"); InputData("pound"); InputData("poverty"); InputData("powder"); InputData("power");
            InputData("powwow"); InputData("practical"); InputData("pragmatic"); InputData("praise"); InputData("precipitation");
            InputData("prawn"); InputData("precise"); InputData("prelude"); InputData("precondition"); InputData("predict");
            // 3100
            InputData("preen"); InputData("preference"); InputData("pregnancy"); InputData("prehistory"); InputData("prejudge");
            InputData("premediation"); InputData("premium"); InputData("premise"); InputData("prepaid"); InputData("prepare");
            InputData("preserve"); InputData("presentation"); InputData("president"); InputData("pressure"); InputData("prestige");
            InputData("presuppose"); InputData("pretension"); InputData("prevail");InputData("prevent"); InputData("preview");
            InputData("price"); InputData("pride"); InputData("primary"); InputData("prime"); InputData("primitive");
            InputData("primrose"); InputData("principle"); InputData("print"); InputData("prisoner"); InputData("privacy");
            InputData("private"); InputData("prize"); InputData("probability"); InputData("probe"); InputData("proceed");
            InputData("process"); InputData("proctor"); InputData("procure"); InputData("procurer"); InputData("producer");
            InputData("profess"); InputData("professional"); InputData("profit"); InputData("propel"); InputData("proper");
            InputData("property"); InputData("prophetic"); InputData("propose"); InputData("proposal"); InputData("proposition");

            InputData("protest"); InputData("providence"); InputData("province"); InputData("provoke"); InputData("provost");
            InputData("psalm"); InputData("psychic"); InputData("public"); InputData("pudgy"); InputData("pugnacity");
            InputData("pullet"); InputData("pulley"); InputData("pulmonary"); InputData("punctual"); InputData("punish");
            InputData("puppy"); InputData("purchaser"); InputData("purify"); InputData("purity"); InputData("purse");
            InputData("pursuit"); InputData("pusher"); InputData("putrid"); InputData("puzzle"); InputData("python");
            InputData("quack"); InputData("quail"); InputData("qualified"); InputData("quart"); InputData("quarterdeck"); // Q
            InputData("queen"); InputData("quell"); InputData("quench"); InputData("question"); InputData("quick");
            InputData("quiet"); InputData("quill"); InputData("quite"); InputData("quits"); InputData("quote");
            InputData("rabbit"); InputData("raccoon"); InputData("racial"); InputData("radar"); InputData("radiation"); // R
            InputData("radio"); InputData("radioactive"); InputData("radish"); InputData("radius"); InputData("ragged");
            // 3200
            InputData("raider"); InputData("railway"); InputData("rainbow"); InputData("raise"); InputData("raisin");
            InputData("rally"); InputData("ramble"); InputData("rampage"); InputData("random"); InputData("range");
            InputData("ranger"); InputData("ransom"); InputData("rapid"); InputData("rapist"); InputData("rapport");
            InputData("rapture"); InputData("rasher"); InputData("rather"); InputData("rational"); InputData("rattle");
            InputData("rattlesnake"); InputData("raven"); InputData("rayon"); InputData("reach"); InputData("reaction");
            InputData("reader"); InputData("realign"); InputData("realism"); InputData("reason"); InputData("reassign");
            InputData("recap"); InputData("recede"); InputData("receive"); InputData("recent"); InputData("reception");
            InputData("reckon"); InputData("recommend"); InputData("reconstruct"); InputData("recover"); InputData("record");
            InputData("rector"); InputData("recycle"); InputData("redeem"); InputData("redone"); InputData("reduce");
            InputData("refer"); InputData("refill"); InputData("reflector"); InputData("reform"); InputData("refuge");

            InputData("regain"); InputData("regard"); InputData("refract"); InputData("refresh"); InputData("regency");
            InputData("register"); InputData("regular"); InputData("rejuvenation"); InputData("relate"); InputData("relax");
            InputData("relevant"); InputData("reliable"); InputData("relief"); InputData("relocation"); InputData("remind");
            InputData("reminder"); InputData("remit"); InputData("remote"); InputData("render"); InputData("renege");
            InputData("renown"); InputData("renter"); InputData("repeal"); InputData("repertory"); InputData("report");
            InputData("represent"); InputData("reproduce"); InputData("repulse"); InputData("require"); InputData("requirement");
            InputData("resent"); InputData("reserve"); InputData("reside"); InputData("resist"); InputData("resolution");
            InputData("resolve"); InputData("respect"); InputData("respiration"); InputData("response"); InputData("responsive");
            InputData("restitution"); InputData("resurrect"); InputData("retail"); InputData("retake"); InputData("retard");
            InputData("restrict"); InputData("retire"); InputData("retreat"); InputData("return"); InputData("reunion");
            // 3300
            InputData("revenge"); InputData("reveal"); InputData("reverse"); InputData("revise"); InputData("revive");
            InputData("revolver"); InputData("reward"); InputData("rework"); InputData("rewrite"); InputData("rhapsody");
            InputData("rhino"); InputData("rhythm"); InputData("ribbon"); InputData("rickets"); InputData("riddle");
            InputData("ridge"); InputData("riffraff"); InputData("right"); InputData("rigid"); InputData("rigor");
            InputData("ringer"); InputData("rinse"); InputData("ripple"); InputData("riser"); InputData("ritual");
            InputData("rival"); InputData("river"); InputData("roach"); InputData("roadblock"); InputData("roadway");
            InputData("robber"); InputData("robot"); InputData("robust"); InputData("rocker"); InputData("rocky");
            InputData("rodent"); InputData("rogue"); InputData("roller"); InputData("roman"); InputData("romantic");
            InputData("rookie"); InputData("roomer"); InputData("rooster"); InputData("rosary"); InputData("rostrum");
            InputData("rotary"); InputData("rotate"); InputData("rotten"); InputData("rough"); InputData("roulette");

            InputData("round"); InputData("routine"); InputData("rower"); InputData("royal"); InputData("rubber");
            InputData("rueful"); InputData("ruffle"); InputData("ruination"); InputData("ruler"); InputData("rumble");
            InputData("ruminant"); InputData("rumple"); InputData("runaway"); InputData("rundown"); InputData("rupture");
            InputData("rural"); InputData("russet"); InputData("russia"); InputData("rustic"); InputData("ruthless");
            InputData("sabbath"); InputData("saber"); InputData("sachet"); InputData("sacrament"); InputData("sacrifice"); // S
            InputData("saddle"); InputData("sadism"); InputData("safari"); InputData("safeguard"); InputData("safety");
            InputData("saffron"); InputData("sailboat"); InputData("salad"); InputData("salesclerk"); InputData("salespeople");
            InputData("salivate"); InputData("salmon"); InputData("salon"); InputData("salutary"); InputData("salute");
            InputData("salvage"); InputData("salvo"); InputData("samaritan"); InputData("sampler"); InputData("sanctify");
            InputData("sanctum"); InputData("sandal"); InputData("sander"); InputData("sandpaper"); InputData("sanitary");
            // 3400
            InputData("sanitize"); InputData("sarsaparilla"); InputData("satire"); InputData("satisfaction"); InputData("satisfactory");
            InputData("satusfy"); InputData("saturate"); InputData("saunter"); InputData("saver"); InputData("savior");
            InputData("sawmill"); InputData("saxophone"); InputData("scabies"); InputData("scaffolding"); InputData("scalene");
            InputData("scallop"); InputData("scamper"); InputData("scandal"); InputData("scant"); InputData("scanty");
            InputData("scarce"); InputData("scarecrow"); InputData("scavenge"); InputData("scene"); InputData("scenery");
            InputData("schedule"); InputData("scheme"); InputData("scholar"); InputData("school"); InputData("schooner");
            InputData("science"); InputData("scoff"); InputData("scoop"); InputData("scorch"); InputData("score");
            InputData("scorecard"); InputData("scorn"); InputData("scotch"); InputData("scour"); InputData("scrabble");
            InputData("scramble"); InputData("scram"); InputData("scrape"); InputData("scratch"); InputData("scream");
            InputData("screen"); InputData("screwdriver"); InputData("scrub"); InputData("scruff"); InputData("scuba");

            InputData("sculpture"); InputData("scummy"); InputData("scuttle"); InputData("scythe"); InputData("seacoast");
            InputData("seafood"); InputData("seaman"); InputData("seamless"); InputData("seamy"); InputData("search");
            InputData("seaside"); InputData("season"); InputData("seaward"); InputData("second"); InputData("secretive");
            InputData("section"); InputData("sector"); InputData("secure"); InputData("sedan"); InputData("sedentary");
            InputData("seduction"); InputData("seedy"); InputData("seesaw"); InputData("seethe"); InputData("segmentation");
            InputData("seizure"); InputData("selective"); InputData("selectivity"); InputData("selfish"); InputData("semifinal");
            InputData("senate"); InputData("senator"); InputData("senile"); InputData("senior"); InputData("sense");
            InputData("sensitive"); InputData("sensory"); InputData("sentence"); InputData("sentiment"); InputData("sentinel");
            InputData("septic"); InputData("september"); InputData("sequel"); InputData("serenade"); InputData("sergeant");
            InputData("sermon"); InputData("serve"); InputData("server"); InputData("service"); InputData("session");
            // 3500
            InputData("setback"); InputData("settlement"); InputData("seven"); InputData("several"); InputData("severe");
            InputData("sewage"); InputData("sextet"); InputData("shabby"); InputData("shade"); InputData("shadow");
            InputData("shaft"); InputData("shake"); InputData("shaker"); InputData("shall"); InputData("shale");
            InputData("shallow"); InputData("shame"); InputData("shape"); InputData("share"); InputData("sharp");
            InputData("sharpen"); InputData("shatter"); InputData("shaver"); InputData("sheath"); InputData("sheep");
            InputData("sheet"); InputData("shelf"); InputData("shelter"); InputData("shelves"); InputData("shiest");
            InputData("shift"); InputData("shifty"); InputData("shine"); InputData("shiny"); InputData("shipload");
            InputData("shipwreck"); InputData("shiver"); InputData("shock"); InputData("shoddy"); InputData("shoehorn");
            InputData("shook"); InputData("shoot"); InputData("shooter"); InputData("shopkeeper"); InputData("shore");
            InputData("short"); InputData("shortage"); InputData("shorten"); InputData("shortness"); InputData("shoulder");

            InputData("shout"); InputData("shovel"); InputData("shower"); InputData("shriek"); InputData("shrine");
            InputData("shrink"); InputData("shrivel"); InputData("shuffle"); InputData("shunt"); InputData("shut");
            InputData("shuttle"); InputData("sibling"); InputData("sicken"); InputData("sidelong"); InputData("sideways");
            InputData("siege"); InputData("sight"); InputData("sign"); InputData("signal"); InputData("signet");
            InputData("silage"); InputData("silence"); InputData("silent"); InputData("silhouette"); InputData("silliness");
            InputData("similar"); InputData("simmer"); InputData("simple"); InputData("simulation"); InputData("since");
            InputData("sinful"); InputData("single"); InputData("sinister"); InputData("siphon"); InputData("siren");
            InputData("sister"); InputData("situate"); InputData("sizable"); InputData("sizzle"); InputData("skater");
            InputData("skeptic"); InputData("sketch"); InputData("skill"); InputData("skimp"); InputData("skinner");
            InputData("skull"); InputData("skunk"); InputData("slack"); InputData("slacker"); InputData("slander");
            // 3600
            InputData("slant"); InputData("slavish"); InputData("sleep"); InputData("sleuth"); InputData("slice");
            InputData("slingshot"); InputData("slink"); InputData("slipper"); InputData("slobber"); InputData("slouch");
            InputData("slowdown"); InputData("sluggish"); InputData("sluice"); InputData("slung"); InputData("slunk");
            InputData("small"); InputData("smart"); InputData("smash"); InputData("smell"); InputData("smelt");
            InputData("smirk"); InputData("smoke"); InputData("smooch"); InputData("smooth"); InputData("smote");
            InputData("snack"); InputData("snake"); InputData("snail"); InputData("snappy"); InputData("sneak");
            InputData("sneer"); InputData("sneeze"); InputData("snipe"); InputData("snivel"); InputData("snoopy");
            InputData("snout"); InputData("snowball"); InputData("snuff"); InputData("snuggle"); InputData("soapy");
            InputData("social"); InputData("society"); InputData("socket"); InputData("sodium"); InputData("softball");
            InputData("soften"); InputData("soggy"); InputData("solace"); InputData("solder"); InputData("soldier");

            InputData("solecism"); InputData("solid"); InputData("solidify"); InputData("solstice"); InputData("solvent");
            InputData("somber"); InputData("somebody"); InputData("someday"); InputData("somehow"); InputData("somnolent");
            InputData("sonata"); InputData("sooty"); InputData("sophist"); InputData("soppy"); InputData("sordid");
            InputData("sorrel"); InputData("sorrow"); InputData("sorry"); InputData("sorter"); InputData("sound");
            InputData("sounder"); InputData("soundness"); InputData("soupbone"); InputData("south"); InputData("southern");
            InputData("soviet"); InputData("sower"); InputData("soybean"); InputData("space"); InputData("spaceship");
            InputData("spaniel"); InputData("spake"); InputData("spank"); InputData("spanish"); InputData("spark");
            InputData("sparrow"); InputData("sparse"); InputData("spasmodic"); InputData("spatter"); InputData("spatial");
            InputData("speak"); InputData("spawn"); InputData("speaker"); InputData("special"); InputData("species");
            InputData("spectrum"); InputData("speck"); InputData("speculate"); InputData("speed"); InputData("speechless");
            // 3700
            InputData("spell"); InputData("speedy"); InputData("speller"); InputData("spend"); InputData("sphere");
            InputData("sphinx"); InputData("spice"); InputData("spicy"); InputData("spill"); InputData("spinach");
            InputData("spiral"); InputData("spirit"); InputData("spiritual"); InputData("splash"); InputData("splendid");
            InputData("splice"); InputData("split"); InputData("splotch"); InputData("splutter"); InputData("spoilt");
            InputData("sponger"); InputData("sponsor"); InputData("spoon"); InputData("sport"); InputData("spore");
            InputData("sporty"); InputData("spotter"); InputData("sprag"); InputData("sprayer"); InputData("sprawl");
            InputData("spread"); InputData("spree"); InputData("spring"); InputData("sprinkle"); InputData("sprint");
            InputData("sprite"); InputData("sprout"); InputData("spunky"); InputData("spurt"); InputData("spyglass");
            InputData("squab"); InputData("squall"); InputData("squat"); InputData("square"); InputData("squeak");
            InputData("squeal"); InputData("squeeze"); InputData("squint"); InputData("squire"); InputData("squid");

            InputData("squirm"); InputData("stability"); InputData("stack"); InputData("stagger"); InputData("stagnancy");
            InputData("stain"); InputData("stake"); InputData("stair"); InputData("stale"); InputData("stall");
            InputData("stamp"); InputData("stance"); InputData("stand"); InputData("standart"); InputData("stank");
            InputData("staple"); InputData("stare"); InputData("start"); InputData("startle"); InputData("state");
            InputData("stash"); InputData("statics"); InputData("station"); InputData("statue"); InputData("stature");
            InputData("stave"); InputData("stay"); InputData("stead"); InputData("steak"); InputData("steam");
            InputData("steed"); InputData("steep"); InputData("steer"); InputData("stellar"); InputData("stench");
            InputData("stereo"); InputData("stern"); InputData("stick"); InputData("sticky"); InputData("stiffen");
            InputData("still"); InputData("stiletto"); InputData("stink"); InputData("stint"); InputData("stitch");
            InputData("stock"); InputData("stockpile"); InputData("stoke"); InputData("stomach"); InputData("stony");
            // 3800
            InputData("stoop"); InputData("stonecutter"); InputData("stopper"); InputData("store"); InputData("storm");
            InputData("stove"); InputData("strafe"); InputData("straight"); InputData("strain"); InputData("strangle");
            InputData("strap"); InputData("straw"); InputData("streak"); InputData("streamer"); InputData("street");
            InputData("strength"); InputData("stress"); InputData("strict"); InputData("stride"); InputData("struck");
            InputData("strike"); InputData("string"); InputData("strip"); InputData("stripe"); InputData("stroke");
            InputData("stroller"); InputData("strong"); InputData("strove"); InputData("struck"); InputData("struggle");
            InputData("strum"); InputData("strut"); InputData("stubble"); InputData("stuck"); InputData("study");
            InputData("stuff"); InputData("stuffy"); InputData("stump"); InputData("stupefy"); InputData("stupid");
            InputData("stutter"); InputData("stylish"); InputData("subconscious"); InputData("subcontractor"); InputData("subdue");
            InputData("subject"); InputData("submit"); InputData("subscription"); InputData("subside"); InputData("subsist");

            InputData("substance"); InputData("substitute"); InputData("subteen"); InputData("subtotal"); InputData("succeed");
            InputData("success"); InputData("succor"); InputData("sucker"); InputData("suction"); InputData("suffer");
            InputData("sufficient"); InputData("sugary"); InputData("suggest"); InputData("suicide"); InputData("suitable");
            InputData("suite"); InputData("suitor"); InputData("sultry"); InputData("summary"); InputData("summer");
            InputData("sumptuous"); InputData("sunbathe"); InputData("sunday"); InputData("sunny"); InputData("suntan");
            InputData("super"); InputData("superior"); InputData("supernatural"); InputData("supervise"); InputData("supplement");
            InputData("supply"); InputData("support"); InputData("suppose"); InputData("suppress"); InputData("supreme");
            InputData("surcharge"); InputData("surface"); InputData("surfeit"); InputData("surgery"); InputData("surpass");
            InputData("surprise"); InputData("surround"); InputData("survey"); InputData("survive"); InputData("suspect");
            InputData("suspense"); InputData("sustain"); InputData("suture"); InputData("swallow"); InputData("swampy");
            // 3900
            InputData("swath"); InputData("swear"); InputData("swadish"); InputData("sweep"); InputData("sweet");
            InputData("swell"); InputData("swift"); InputData("swill"); InputData("swine"); InputData("swing");
            InputData("swipe"); InputData("swirl"); InputData("swiss"); InputData("switchblade"); InputData("swung");
            InputData("syllabus"); InputData("sylvan"); InputData("symbol"); InputData("symphony"); InputData("symptom");
            InputData("synopsis"); InputData("syntax"); InputData("synthetic"); InputData("syringe"); InputData("systematize");
            InputData("table"); InputData("tablet"); InputData("taboo"); InputData("tabulate"); InputData("tacit"); // T
            InputData("tackle"); InputData("tailor"); InputData("taint"); InputData("taken"); InputData("talcum");
            InputData("talented"); InputData("talisman"); InputData("talker"); InputData("talkie"); InputData("tallow");
            InputData("talon"); InputData("tamper"); InputData("tandem"); InputData("tamper"); InputData("tangle");
            InputData("tantrum"); InputData("tapir"); InputData("target"); InputData("tariff"); InputData("tarnish");

            InputData("tarry"); InputData("teach"); InputData("teacher"); InputData("teapot"); InputData("tearful");
            InputData("tease"); InputData("technical"); InputData("technique"); InputData("tedium"); InputData("telegram");
            InputData("telegraph"); InputData("telephoto"); InputData("telescope"); InputData("television"); InputData("teller");
            InputData("tempramental"); InputData("temper"); InputData("tempest"); InputData("temple"); InputData("tempo");
            InputData("temporary"); InputData("temptation"); InputData("tenancy"); InputData("tender"); InputData("tendon");
            InputData("tenpins"); InputData("tension"); InputData("tentacle"); InputData("tenth"); InputData("tercentenary");
            InputData("terminate"); InputData("terrible"); InputData("territorial"); InputData("terror"); InputData("tertiary");
            InputData("testament"); InputData("testimony"); InputData("teutonic"); InputData("texture"); InputData("thailand");
            InputData("thank"); InputData("thanksgiving"); InputData("thatch"); InputData("theater"); InputData("their");
            InputData("theme"); InputData("thence"); InputData("theology"); InputData("theory"); InputData("there");
            // 4000
            InputData("thermal"); InputData("thermometer"); InputData("these"); InputData("thesis"); InputData("thick");
            InputData("thieves"); InputData("thing"); InputData("think"); InputData("third"); InputData("thirst");
            InputData("thirty"); InputData("thistle"); InputData("thorny"); InputData("though"); InputData("thousand");
            InputData("thrash"); InputData("thread"); InputData("threat"); InputData("thrill"); InputData("throat");
            InputData("through"); InputData("throw"); InputData("thrust"); InputData("thunder"); InputData("thyme");
            InputData("tibetan"); InputData("ticket"); InputData("tickle"); InputData("tidal"); InputData("tidbit");
            InputData("tiger"); InputData("tight"); InputData("tiller"); InputData("timbre"); InputData("timely");
            InputData("timpani"); InputData("timorous"); InputData("tinge"); InputData("tingle"); InputData("tinker");
            InputData("tipper"); InputData("tiptoe"); InputData("tiresome"); InputData("title"); InputData("tizzy");
            InputData("toadies"); InputData("toast"); InputData("toddy"); InputData("toddler"); InputData("together");

            InputData("toilet"); InputData("tolerance"); InputData("tollgate"); InputData("tomahawk"); InputData("tomcat");
            InputData("tonal"); InputData("tongue"); InputData("tonic"); InputData("tooth"); InputData("toothy");
            InputData("topic"); InputData("topaz"); InputData("topple"); InputData("torment"); InputData("torsion");
            InputData("torso"); InputData("torture"); InputData("total"); InputData("totem"); InputData("totality");
            InputData("touch"); InputData("tough"); InputData("toupee"); InputData("tourist"); InputData("tower");
            InputData("toxin"); InputData("trace"); InputData("tract"); InputData("trade"); InputData("tractor");
            InputData("tragic"); InputData("trail"); InputData("train"); InputData("trainer"); InputData("traitor");
            InputData("tramp"); InputData("trample"); InputData("trance"); InputData("transaction"); InputData("transcend");
            InputData("transfer"); InputData("transform"); InputData("transient"); InputData("transistory"); InputData("translate");
            InputData("transmute"); InputData("transmission"); InputData("transportation"); InputData("transverse"); InputData("transpose");
            // 4100
            InputData("trappings"); InputData("traverse"); InputData("tread"); InputData("treadmill"); InputData("treasure");
            InputData("treat"); InputData("tremble"); InputData("tremor"); InputData("trench"); InputData("trend");
            InputData("trial"); InputData("triangle"); InputData("tribute"); InputData("trick"); InputData("trickle");
            InputData("trifle"); InputData("trigger"); InputData("trill"); InputData("trinket"); InputData("triple");
            InputData("triumphal"); InputData("trolley"); InputData("trooper"); InputData("trophy"); InputData("trouble");
            InputData("trough"); InputData("truant"); InputData("trudge"); InputData("trump"); InputData("trunk");
            InputData("trust"); InputData("trustee"); InputData("tryout"); InputData("tubby"); InputData("tuber");
            InputData("tulip"); InputData("tuesday"); InputData("tumble"); InputData("tuner"); InputData("tumor");
            InputData("tunic"); InputData("turmoil"); InputData("tunnel"); InputData("turnout"); InputData("tussle");
            InputData("turqoise"); InputData("turtle"); InputData("twill"); InputData("twitter"); InputData("tying");

            InputData("tympani"); InputData("typhoon"); InputData("typographical"); InputData("tyrant"); InputData("typical");
            InputData("ubiquitous"); InputData("ulcer"); InputData("ultimate"); InputData("umbrage"); InputData("umpire"); // U
            InputData("unaccounted"); InputData("unarmed"); InputData("unceasing"); InputData("understand"); InputData("uncoil");
            InputData("uncontrolled"); InputData("unconventional"); InputData("uncouple"); InputData("uncurl"); InputData("undefeated");
            InputData("under"); InputData("undercover"); InputData("underground"); InputData("underworld"); InputData("undivided");
            InputData("undesirable"); InputData("undivided"); InputData("undraped"); InputData("unemployed"); InputData("unequaled");
            InputData("unhappy"); InputData("uniform"); InputData("unimportant"); InputData("unknown"); InputData("unmounted");
            InputData("unpolished"); InputData("unpolluted"); InputData("unproductive"); InputData("unquote"); InputData("unredeemed");
            InputData("unrest"); InputData("unsavory"); InputData("unspeakable"); InputData("untamed"); InputData("until");
            InputData("untold"); InputData("untraveled"); InputData("uptake"); InputData("usual"); InputData("utility");
            // 4200
            InputData("vacant"); InputData("vagabond"); InputData("valance"); InputData("vanguard"); InputData("vaporize"); // V
            InputData("variable"); InputData("varies"); InputData("vatican"); InputData("vegetarian"); InputData("vehement");
            InputData("vehicle"); InputData("venerate"); InputData("venture"); InputData("veracious"); InputData("verity");
            InputData("vertebrate"); InputData("vessel"); InputData("veteran"); InputData("viable"); InputData("vibration");
            InputData("victor"); InputData("vignette"); InputData("village"); InputData("villain"); InputData("virtue");
            InputData("vital"); InputData("vivid"); InputData("vocalic"); InputData("vocation"); InputData("vogue");
            InputData("vocal"); InputData("voice"); InputData("volcanic"); InputData("comit"); InputData("voodoo");
            InputData("voter"); InputData("voucher"); InputData("voyager"); InputData("vulgar"); InputData("vulture");
            InputData("wacky"); InputData("waffle"); InputData("wagon"); InputData("waiter"); InputData("waitress"); // W
            InputData("waken"); InputData("walker"); InputData("wallet"); InputData("wander"); InputData("wangle");

            InputData("warble"); InputData("warlike"); InputData("warmth"); InputData("warranty"); InputData("warrior");
            InputData("waste"); InputData("watch"); InputData("water"); InputData("waterfall"); InputData("watermelon");
            InputData("wattage"); InputData("wattle"); InputData("waver"); InputData("weaken"); InputData("weapon");
            InputData("wary"); InputData("weather"); InputData("weave"); InputData("wedge"); InputData("weedy");
            InputData("weekend"); InputData("weekday"); InputData("weight"); InputData("welcome"); InputData("welsh");
            InputData("western"); InputData("whacky"); InputData("wharves"); InputData("whatever"); InputData("wheel");
            InputData("wheelbarrow"); InputData("whelp"); InputData("whetstone"); InputData("while"); InputData("whirl");
            InputData("whisk"); InputData("whistle"); InputData("white"); InputData("whiten"); InputData("whoever");
            InputData("wicker"); InputData("wicket"); InputData("wiggler"); InputData("wildwood"); InputData("wildlife");
            InputData("willies"); InputData("windbreaker"); InputData("windy"); InputData("winnow"); InputData("winter");
            // 4300
            InputData("wireless"); InputData("wisdom"); InputData("witch"); InputData("withdraw"); InputData("within");
            InputData("witness"); InputData("wizard"); InputData("woman"); InputData("wolverine"); InputData("wonderful");
            InputData("woodcraft"); InputData("woolen"); InputData("woozy"); InputData("worker"); InputData("workman");
            InputData("world"); InputData("worries"); InputData("wormhole"); InputData("worse"); InputData("worship");
            InputData("worth"); InputData("wound"); InputData("wrack"); InputData("wrath"); InputData("wreck");
            InputData("wrench"); InputData("wrestle"); InputData("wring"); InputData("write"); InputData("wrong");
            InputData("xenophobia"); InputData("xylophone"); InputData("yatch"); InputData("yardman"); InputData("yearbook"); // X Y
            InputData("yesterday"); InputData("yogurt"); InputData("yodel"); InputData("young"); InputData("yummy");
            InputData("zealot"); InputData("zeppelin"); InputData("zigzag"); InputData("zombie"); InputData("zipper");


            textBoxAnswer.Text = "";
            index = generator.Next(0, 4345);
            textBoxQuestion.Text = listQuest[index];
        }

        private void InputData (string question)
        {
            listQuest.Add(question);
        }

        private void CheckAnswer ()
        {
            if (textBoxQuestion.Text == textBoxAnswer.Text)
            {
                score += 5;
                tempReq += 5;
                normSound.URL = resourcesPath + "true.wav.wav";
                if (tempReq >= requirement)
                {
                    tempReq = 0;
                    requirement += 10;
                    time += 30;
                    displayTimeExtended = true;
                    timerDisplay.Enabled = true;
                }
            }
            else
            {
                if (score > 0)
                {
                    score -= 5;
                    tempReq -= 5;
                }
                normSound.URL = resourcesPath + "false.wav.wav";
            }
            labelScore.Text = score.ToString();
            textBoxAnswer.Text = "";
            index = generator.Next(0, 4345);
            textBoxQuestion.Text = listQuest[index];
            timerBreak.Enabled = true;
        }

        

        private void timerFrameRate_Tick(object sender, EventArgs e)
        {
            labelScore.Text = score.ToString();
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                CheckAnswer();
                timerFrameRate.Enabled = false;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            time--;
            labelTime.Text = time.ToString();
            if (time == 60)
            {
                display60Secs = true;
                timerDisplay.Enabled = true;
            }
            else if (time == 30)
            {
                display30Secs = true;
                timerDisplay.Enabled = true;
            }
            else if (time == 15)
            {
                display15Secs = true;
                timerDisplay.Enabled = true;
            }
            else if (time <= 5)
            {
                displayCountdown = true;
                timerDisplay.Enabled = true;
                if (time <= 0)
                {
                    timerGame.Enabled = false;
                    MessageBox.Show("Game Over. You Scored : " + score);
                    this.Close();
                }
            }
        }

        private void timerBreak_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyUp(Key.Enter))
            {
                timerFrameRate.Enabled = true;
            }
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            if (displayTimeExtended == true)
            {
                display++;
                if (display == 1 || display == 3 || display == 5 || display == 7)
                {
                    labelTimeExtended.Visible = true;
                }
                else
                {
                    labelTimeExtended.Visible = false;
                }
                if (display == 8)
                {
                    display = 0;
                    displayTimeExtended = false;
                    timerDisplay.Enabled = false;
                }
            }
            else if (display60Secs == true)
            {
                display++;
                if (display == 1 || display == 3)
                {
                    label60Secs.Visible = true;
                }
                else
                {
                    label60Secs.Visible = false;
                }
                if (display == 4)
                {
                    display = 0;
                    display60Secs = false;
                    timerDisplay.Enabled = false;
                }
            }
            else if (display30Secs == true)
            {
                display++;
                if (display == 1 || display == 3 || display == 5 )
                {
                    label30Secs.Visible = true;
                }
                else
                {
                    label30Secs.Visible = false;
                }
                if (display == 6)
                {
                    display = 0;
                    display30Secs = false;
                    timerDisplay.Enabled = false;
                }
            }
            else if (display15Secs == true)
            {
                display++;
                if (display == 1 || display == 3 || display == 5 || display == 7)
                {
                    label15Secs.Visible = true;
                }
                else
                {
                    label15Secs.Visible = false;
                }
                if (display == 8)
                {
                    display = 0;
                    display15Secs = false;
                    timerDisplay.Enabled = false;
                }
            }
            else if (displayCountdown == true)
            {
                if (time <= 5)
                {
                    labelCD1.Text = time.ToString(); labelCD2.Text = time.ToString(); labelCD3.Text = time.ToString(); labelCD4.Text = time.ToString(); labelCD5.Text = time.ToString();
                }
                else
                {
                    displayCountdown = false;
                    labelCD1.Text = ""; labelCD2.Text = ""; labelCD3.Text = ""; labelCD4.Text = ""; labelCD5.Text = "";
                    timerDisplay.Enabled = false;
                }
            }
        }
    }
}