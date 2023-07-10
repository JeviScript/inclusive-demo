import { useEffect, useState } from "react";
import { get } from "../../Api";
import PlanetCard from "../../lib/PlanetCard";
import "./Home.css";

export function Home() {
  const [planets, setPlanets] = useState<Planet[]>([]);

  useEffect(() => {
    getPlanets().then((planets) => {
      setPlanets(planets);
    });
  }, []);

  return <div className="planets">
    {planets.map(p => (
      <PlanetCard key={p.name} link={true} name={p.name} pictureUrl={p.pictureUrl}/>
    ))}
  </div>;
}

interface Planet {
  name: string;
  pictureUrl: string;
}

function getPlanets(): Promise<Planet[]> {
  return get("planets");
}
