using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Rendering.VirtualTexturing;

public class HVACDatabase
{
    private List<HVACType> db = new();

    public HVACDatabase()
    {
        seedData();
    }

    private void seedData()
    {
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.Cooling,
            Name = "Window AC units",
            Description = "A popular type of cooling equipment is window units, which are designed to fit in double- and single-hung windows. " +
            "They’re commonly found in apartments that lack central air conditioning, or providing a cooling boost to single rooms in larger homes.",
            UtilityType = "Electric",
            Prerequisites = "Window",
            Pros = "Window air conditioning units are smaller, more portable, and easier to install than most other types of units. " +
            "They are also the cheapest option for adding air conditioning to your home, especially if you’re working with a tight budget. " +
            "Models manufactured today are up to 30 percent more efficient than those manufactured only a decade ago. " +
            "And many come with warranties as long as five years, so you will have peace of mind when you make your purchase.",
            Cons = "Always remember, window air conditioners aren’t meant to cool your entire home. Even if you live in an apartment, " +
            "you’ll need multiple units to keep the entire apartment comfortable. Each unit you install takes up a window for the entire summer. " +
            "You will also have to deal with loud compressors running in each room. If you decide to go with a larger unit, it may be awkward to install and remove. " +
            "Factors may limit the efficiency of your window air conditioner, including high ceilings, numerous windows and doors, high sun exposure, " +
            "or cooling a room on the top floor.",
            ApproximateCost = "$150 to $500"


        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.Cooling,
            Name = "Portable Air Conditioners",
            Description = "These units are similar to window air conditioners, but the unit sits on the floor instead of sitting in the window. " +
            "Portable air conditioners draw in air, remove heat and moisture, and vents cool dry air into your home. " +
            "The hot and humid air is vented out of your home through an exhaust host going out the window. " +
            "This is only a superior option to window units if you have the wrong kind of windows or are worried about installing a window unit.",
            UtilityType = "Electric",
            Prerequisites = "Window",
            Pros = "Portable units are even easier to install than window units. " +
            "The floor unit rolls around on casters so you can quickly position or move it, " +
            "and the hose leading out the window does not obstruct your view. Plus, the hose is easy to take out of the window temporarily when the weather is nice.",
            Cons = "According to Consumer Reports, portable air conditioners usually only deliver half the cooling capacity they claim, " +
            "leaving you feeling hot and sweaty even if the unit is running full bore. " +
            "They’re also typically more expensive and less efficient than similarly sized window units, " +
            "which drives up purchasing and operating costs. Noise can be another factor, " +
            "and most portable air conditioners have reservoirs that need to be manually drained as the unit removes humidity from the air.",
            ApproximateCost = "$250 and $500"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.Cooling,
            Name = "Ductless Mini Split AC",
            Description = "A ductless mini-split is essentially a heat pump minus the ductwork. It has two main components. " +
            "One is an outdoor compressor, similar to one you would find in a central AC unit. " +
            "The second is an indoor evaporator coil and air handling unit placed on a wall or the ceiling. " +
            "A conduit links the two units together through a tiny hole in the wall. " +
            "Ductless mini-split air conditioners are built to cool older homes without ductwork, or smaller homes and add-ons where ductwork isn’t practical. " +
            "Some Ductless AC models have higher efficiency ratings that any other type of air conditioner.",
            UtilityType = "Electric",
            Prerequisites = "None",
            Pros = "The greatest advantage to a mini-split system is their ability to provide flexible cooling to each individual part of your home through a smaller, " +
            "more energy efficient operation. It’s as close as you can get to central air without having to tear up your ceiling and walls for ductwork. " +
            "Also, since mini-splits are a type of heat pump, they can provide heating for your home in the winter. " +
            "An added bonus to a ductless system is that they are as quiet as an ordinary fan. With a compressor located outside, " +
            "the unit is much quieter than a window or portable air conditioner. Plus, there is no need to obstruct the window with a unit or exhaust, " +
            "so you have an unobstructed view outside, the ability to operate the window as you wish, and better home security.",
            Cons = "Ductless mini-splits are more expensive than window or portable units. " +
            "You will need to hire a professional to perform the installation, " +
            "which includes linking the indoor and outdoor components by drilling a three-inch hole in the wall. " +
            "And you need to take interior design considerations into account, because the unit needs to mount to the wall or ceiling of the room.",
            ApproximateCost = "$2,000 and $14,500"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.Cooling,
            Name = "Central AC System",
            Description = "This system is the best way to cool your entire home. " +
            "Central Air distributes cooled air throughout ductwork with return and supply registers in each room. " +
            "The air conditioning components are located outside, except for the air handler, which is typically shared with the furnace. " +
            "If you have ductwork in place and are looking for whole-house cooling, this is the most popular system.",
            UtilityType = "Electric",
            Prerequisites = "Ducting",
            Pros = "A central AC system is the most efficient way to keep your entire home cool. " +
            "This system ensures that you lower energy bills and maintain indoor comfort with cooler temperatures and lower humidity. " +
            "And with components located outside, you can keep cool with a nearly invisible, silent system. " +
            "Central AC systems are also a valuable investment as a permanent fixture to your home.",
            Cons = "Central air conditioning systems require annual maintenance to stay in top working condition for years to come. " +
            "You should prepare for higher upfront costs, especially if you also need to install ductwork. " +
            "However, replacing an existing central air unit is cheaper than installing a new ductless mini-split." +
            "The final question is what size air conditioning system you need.If you choose a unit that is undersized, " +
            "it won’t keep up on the hottest days.An oversized unit will short cycle, wearing out the parts faster even though the system can’t dehumidify your home.",
            ApproximateCost = "$3,800 to $7,500"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Electric Furnace",
            Description = "Furnaces are the most common form of central heating system used in North America. " +
            "A furnace is an appliance that heats up air and blows it through the ducts via air registers or grills. " +
            "A furnace can be powered by electricity, natural gas, or fuel oil.",
            UtilityType = "Electric",
            Prerequisites = "Ducting",
            Pros = "A benefit to using an electric furnace over the other fuel types is that electric furnaces don’t produce carbon monoxide. " +
            "The lack of carbon monoxide production makes the system more environmentally friendly and easier to install. " +
            "Electric furnaces are also 100 percent efficient, because all of the electricity used is put toward heating your home.",
            Cons = "A major disadvantage to electric furnaces is the cost to run them. " +
            "Electricity tends to be more expensive than gas in many regions. In some areas, " +
            "electric furnaces are paired with heat pumps to allow for a greater savings in cost when compared to electricity alone.",
            ApproximateCost = "$1,600 to $6,200"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Gas Furnace",
            Description = "A gas furnace is a home heating appliance that runs off of natural gas. " +
            "The natural gas is ignited in the furnace, warming up the air, which is then delivered throughout the home." +
            "Modern gas furnaces are among the most efficient ways to heat your home with Annual Fuel Utilization Efficiencies (AFUE) ratings reaching 98.5%.",
            UtilityType = "Gas",
            Prerequisites = "Ducting",
            Pros = "Natural gas is extremely reliable and it is less expensive than other fossil fuels. " +
            "It also burns cleaner than other fossil fuels making it environmentally friendly and is safer and easier to store when compared to other fossil fuels. " +
            "Lower fuel costs and improved energy efficiency make natural gas furnaces typically cheaper to run. " +
            "Desired temperatures are reached faster than an electrically powered furnace, using significantly less fuel while heating-up.",
            Cons = "A Natural gas furnace is generally more expensive upfront and may be more expensive to install if it requires plumbing into a supply line. " +
            "The main disadvantage of natural gas furnaces is the generation of emissions.",
            ApproximateCost = "$1,700 to $9,700"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Oil Furnace",
            Description = "Heating oil has been used since the 1920s and continues to be used because of the distinct advantages it provides as a heating fuel. " +
            "Modern oil-burning furnaces are not often quite as fuel-efficient as gas or electric furnaces, " +
            "but heating oil burns hotter than either gas or electricity and can often heat a building more quickly.",
            UtilityType = "Oil",
            Prerequisites = "Ducting",
            Pros = "Initial installation price tends to be higher for oil furnaces, but they can make up for the cost with their durability and longevity: " +
            "oil furnaces can last for 20–30 years compared to the 12–15 years expected of an electric furnace. " +
            "Heating oil burns hotter than either gas or electricity and can often heat a building more quickly. " +
            "Oil furnaces produce very little harmful byproducts. Unlike natural gas, heating oil is not flammable or explosive, making this type of furnace one of the safest options.",
            Cons = "Modern oil-burning furnaces are not often quite as fuel-efficient as gas or electric furnaces. " +
            "Annual heating bills can fluctuate depending on the price of oil products in a given year, " +
            "which can make heating costs for an oil furnace more or less than gas or electric options.",
            ApproximateCost = "$4,300 to $9,200"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Gas Boiler",
            Description = "Boilers are special-purpose water heaters. Boiler systems distribute the heat in hot water, " +
            "which gives up heat as it passes through radiators or other devices in rooms throughout the house. " +
            "The cooler water then returns to the boiler to be reheated. Hot water systems are often called hydronic systems.",
            UtilityType = "Natural Gas",
            Prerequisites = "None",
            Pros = "Evenly distributes heat throughout a home, which is sometimes a complaint with forced air systems." +
            "Boiler heat is clean, meaning you don’t get all of the allergens and other particles blown throughout your home, " +
            "along with the warm air – water heating systems are great if you’re after optimal indoor air quality. " +
            "There is little routine maintenance required for boilers (i.e. no filters to change, etc.).",
            Cons = "Often cost more to install than forced air systems because many homes need to be outfitted with the proper piping systems, etc. " +
            "Replacement parts for boilers can be more expensive than those for forced air systems. " +
            "You can’t cool your home with a boiler, which means that additional ductwork, etc. is required if you wish to install air conditioning. " +
            "Can take longer to respond when the thermostat is changed.",
            ApproximateCost = "$3,760 to $6,730"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Heat Pump",
            Description = "A heat pump takes heat energy from one place and moves it to another by compressing and expanding refrigerant. " +
            "A heat pump extracts heat from the air and transfers this heat to either the inside or outside of your home, " +
            "depending on the season. A central heat pump distributes heat and cool air through ductwork connected to vents in each room.",
            UtilityType = "Electric",
            Prerequisites = "Ducting",
            Pros = "One of the key advantages to an electric heat pump is the efficiency with which it operates; " +
            "it will keep your home comfortable while keeping your energy bills down. " +
            "Another advantage of an electric heat pump is humidity control; the heat pump doesn’t dry out the air when heating in the way that traditional gas heaters do. " +
            "You probably won’t need to use a humidifier during the wintertime. " +
            "Lastly, Gas furnaces in the home come with an inherent safety concern; you’ll always have to be aware of the possibility of a gas leak or even a fire or explosion that could occur. " +
            "As they do not make use of natural gas, electric heat pumps do not have this issue and are generally safer in your home than gas furnaces.",
            Cons = "While having an electric heat pump is likely to save you on energy costs in the long run, they’re not particularly cheap to install. " +
            "Electric heat pumps do require more care and maintenance to keep them operating at maximum efficiency. " +
            "Lastly, Electric Heat Pumps Are Larger Than Other Systems because an electric heat pump needs to have both an indoor and outdoor component.",
            ApproximateCost = "$3,875 to $10,000"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Micro Combined Heat and Power",
            Description = "Micro combined heat and power (micro-CHP) is a technology that generates heat and electricity simultaneously, " +
            "from the same energy source, in individual homes or buildings. Micro-CHP systems are a similar size and shape to standard domestic boilers. " +
            "They can be mounted on a wall or can stand on the floor. Domestic micro-CHP systems are usually powered by mains gas or liquified petroleum gas (LPG) " +
            "and the technology is considered a low carbon technology because it can be more efficient than just burning fossil fuel for heat and getting electricity from the grid.",
            UtilityType = "Natural Gas",
            Prerequisites = "None",
            Pros = "When the micro-CHP is generating heat, the unit will also generate electricity to be used in your home (or exported). " +
            "Micro- CHP systems increase efficiency of fuel. Approximately 85% of the energy put into a system is used for either electrical power or heating and cooling purposes." +
            "Lastly, Micro-CHP systems allow you to cut your carbon footprint by generating electricity on-site. If you already have a conventional boiler, " +
            "then a micro-CHP unit should be able to replace it, as it’s roughly the same size.",
            Cons = "One major disadvantage of micro-CHP systems is the high initial costs of the equipment that make up the systems. " +
            "A micro-CHP system will cost more than a traditional boiler. Aside from that, a micro-CHP system is not seen as a true sustainable energy source " +
            "(being predominantly fuelled by natural gas) unless it can be used with renewable fuels such as Biogas produced from AD plants, or Hydrogen mixture.",
            ApproximateCost = "$21,000+"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.CentralizedHeating,
            Name = "Electric Radiant Floor Heating",
            Description = "Radiant floor systems come in several styles, but one of the most popular is the electric system, " +
            "in which a wire mesh or loops of individual wires run across the floor beneath the surface, " +
            "creating warmth by means of the natural resistance occurring as electricity flows through the metal wires.",
            UtilityType = "Electric",
            Prerequisites = "None",
            Pros = "Electric radiant heating systems buried within thermal masses (such as between cement board and ceramic tile) " +
            "can retain heat for a long time, even after the power is turned off. They are easy to install during remodeling projects." +
            "Radiant systems, in general, are more cost-effective than other means of electric supplemental heating, such as space heaters." +
            "Lastly, Electric radiant floor systems offer a discreet way of heating a floor.",
            Cons = "These systems are difficult to install retroactively, as the floor covering must be removed. " +
            "They are most practical during new construction or during major remodeling projects. " +
            "They are more effective at warming the floor surface \"to the touch,\" rather than heating the entire room. " +
            "Radiant floor heating is less effective under carpeting, hardwood, or vinyl since heat can be trapped between the insulating surface layer and the subfloor.",
            ApproximateCost = "$20,000 to $35,000(average 2,000 sq ft home)"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.DirectedHeating,
            Name = "Gas Fired Space Heaters",
            Description = "In some areas, gas-fired direct heating equipment is popular. This includes wall-mounted, free-standing, and floor furnaces, " +
            "all characterized by their lack of ductwork and relatively small heat output. Because they lack ducts, they are most useful for warming a single room. " +
            "If heating several rooms is required, either the doors between rooms must be left open or another heating method is necessary.",
            UtilityType = "Natural Gas",
            Prerequisites = "None",
            Pros = "It is cheaper to run a gas heater than an electric one. " +
            "Aside from this, gas heaters warm up the house quicker and produce warmer heat than other types of space heaters. " +
            "If you do plan to use a gas-powered space heater inside, look for safety features such as a low oxygen sensor, " +
            "high-temperature coated safety guard, overheat protection, and an automatic shut-off in case the device gets knocked over.",
            Cons = "They rely on fuel that’s flammable and prone to the emission of harmful carbon dioxide. " +
            "Aside from that, they need special venting to discharge combustion gasses and they have a shorter lifespan. " +
            "It also requires a gas line and the installation is generally more complex. Lastly, it can cause a carbon monoxide leak.",
            ApproximateCost = "$200 to $800"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.DirectedHeating,
            Name = "Electric Space Heaters",
            Description = "Portable (plug-in) electric heaters are inexpensive to buy, but costly to use. " +
            "These resistive heaters include “oil-filled” and “quartz-infrared” heaters. " +
            "They convert electric current from the wall socket directly into heat, like a toaster or clothes iron.",
            UtilityType = "Electric",
            Prerequisites = "None",
            Pros = "Almost all of the electricity consumed by a space heater is converted to heat, so the units themselves are nearly 100% efficient. " +
            "They are portable, so you can move them to the bedroom by night and the home office by day. " +
            "Provide comfortable heat and it is easy to install. Practically no maintenance is required. " +
            "Temperature controlled heating. No heat leakage and no pipework required.",
            Cons = "Government regulations limit space heater output to 1,500 watts, which is not nearly enough to heat an entire home. " +
            "In general, one square foot of space requires about 10 watts of electricity to heat, " +
            "which means that a space heater operating at its maximum output can heat a room no larger than 150 square feet. " +
            "Aside from that, electricity can be expensive depending on the area and a power cut can leave you without heating.",
            ApproximateCost = "$50 to $150"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.DirectedHeating,
            Name = "Wood Burning Stoves",
            Description = "Wood burning stoves are self-contained heating appliances designed to produce indoor heat through wood combustion. " +
            "A wood fire is contained in the body of the stove, which is usually made of steel or cast iron. " +
            "The fire warms the body of the stove, which radiates heat into the surrounding space. " +
            "Smoke from the fire leaves the building through a pipe (called the flue) that leads to a chimney.",
            UtilityType = "Wood",
            Prerequisites = "None",
            Pros = "Wood stoves provide radiant heat, which means that these units give off powerful heat in all directions " +
            "and can warm an area in your home faster and more efficiently than your home’s vent system. " +
            "Wood is much more environmentally friendly when compared with the typical fossil fuels (oil and gas) you typically see in home heating units. " +
            "With a few well-placed stoves, you can zone-heat any room or space and almost completely remove the need for a central heating system.",
            Cons = "Regular use of your wood stove requires a never-ending supply of logs to fuel your fire. " +
            "If you must purchase your cordwood, it cancels out the cost-efficiency of a wood stove. " +
            "Additionally, depending on your location and the time of year, you can expect to pay more. " +
            "Wood systems also require more space to store this bulky fuel. Wood stoves requires regular tending (at least twice a day) when they’re running full time. " +
            "Many modern wood stoves have a catalytic combustor, which usually involves inspection three times a season. " +
            "Additionally, you’ll need to schedule a chimney cleaning and inspection at least once a year to remove excess residue and soot to ensure safety.",
            ApproximateCost = "$1,450 to $9,600"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.DirectedHeating,
            Name = "Fireplaces",
            Description = "A fireplace is an open area built into the structure of a home where a fire can be safely contained to generate heat and to provide a relaxing atmosphere, " +
            "while allowing waste gasses and smoke to leave the property via a chimney.",
            UtilityType = "Wood",
            Prerequisites = "None",
            Pros = "They don’t require electricity because wood-burning fireplaces rely on using actual wood as their power source, your fireplace would still work even if the power goes out. " +
            "This could be an effective backup source of heat and light in the event of an Iowa snowstorm, and it would even give you and your family a means to cook food if needed. " +
            "A wood-burning fireplace is your best choice if you want the ambiance and authenticity of a crackling fire. " +
            "While any fireplace can add a cozy, homey feel to a room, no other option can beat the atmosphere created by a traditional fireplace.",
            Cons = "The authenticity of real wood logs also means that you have to have a supply of logs in order for your fireplace to work, " +
            "and using your fireplace requires actually starting a fire yourself. " +
            "Along with starting the fire, homeowners also have to regularly clean ashes out of their fireplace to prevent buildup.",
            ApproximateCost = "$700 and $30,000"
        });
        db.Add(new HVACType()
        {
            Kind = HVACType.Type.DirectedHeating,
            Name = "Ductless Mini Split System",
            Description = "A ductless HVAC system or mini split is a heating and cooling system designed to deliver warm or " +
            "cool air to a single room or several without the need for connective ductwork. " +
            "Mini-split systems heat or cool your home by: Pulling in the hot or cold air inside a room. Running the air over warm or cold refrigerant coils. " +
            "Pushing the air back into the room. Sending the refrigerant to the outdoor unit to expel the heat or cold.",
            UtilityType = "Electric",
            Prerequisites = "None",
            Pros = "If your home doesn't have ductwork, a mini-split HVAC system will be easier to install than installing ductwork for a forced air HVAC system. " +
            "Mini-split systems are consistently more energy efficient than traditional HVAC systems because they don't lose conditioned air to leaky ducts. " +
            "Since each unit in a mini-split system is designed to only cool a small area, you can keep different areas at different temperatures if needed.",
            Cons = "Ductless HVAC systems cost roughly 30% more than forced air HVAC systems. " +
            "How much you'll pay for your mini-split system will increase with the: Number of rooms you want heated or cooled, size of the system, and system's efficiency. " +
            "Mini-split systems need an indoor unit for every area they're cooling or heating, which means you'll need several units on walls or ceilings throughout your home. " +
            "Ductless HVAC systems work well in moderate temperatures, but start to lose efficiency when temperatures get below freezing or above 95°-100°. " +
            "Lastly, you need to clean the reusable filter monthly to keep them running efficiently.",
            ApproximateCost = "$3,600 t0 $29,000"
        });
    }

    public List<HVACType> findAll()
    {
        return db;
    }

    public List<HVACType> findAllCoolingUnits()
    {
        return db.Where(x => x.Kind == HVACType.Type.Cooling).ToList();
    }

    public List<HVACType> findAllCentralizedHeating()
    {
        return db.Where(x => x.Kind == HVACType.Type.CentralizedHeating).ToList();
    }

    public List<HVACType> findAllDirectedHeating()
    {
        return db.Where(x => x.Kind == HVACType.Type.DirectedHeating).ToList();
    }
}


