import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { get } from "../../Api";
import PlanetCard from "../../lib/PlanetCard";
import styles from "./Planet.module.scss";

export function Planet() {
  const { name } = useParams();
  const [planet, setPlanet] = useState<Planet>();
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    if (name) {
      getPlanet(name).then((p) => {
        setLoading(false);
        setPlanet(p);
      });
    }
  }, [name]);
  return (
    <div>
      {planet && (
        <div className={styles["planet-wrapper"]}>
          <PlanetCard
            link={false}
            name={planet.name}
            pictureUrl={planet.pictureUrl}
          />
          <Details planet={planet} />
        </div>
      )}
      {loading && <p>loading...</p>}
    </div>
  );
}

interface Planet {
  name: string;
  description: string;
  pictureUrl: string;
  sunDistance: number; // million km
  mass: string;
  diameter: number; // km
}

function getPlanet(name: string): Promise<Planet> {
  return get(`planets/${name}`);
}

function Details({ planet }: { planet: Planet }) {
  return (
    <div className={styles.details}>
      <p>{planet.description}</p>

      <br />

      <p>Mass: {planet.mass}</p>
      <p>Diameter: {planet.diameter} km</p>
      <p>Sun distance: {planet.sunDistance} million km</p>
    </div>
  );
}
