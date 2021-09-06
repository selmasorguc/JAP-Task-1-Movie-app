import { Actor } from "./actor";

export interface Movie {
    id: number;
    title: string;
    coverUrl: string;
    releaseDate: Date;
    description: string;
    rating: number;
    cast: Actor[];
  }