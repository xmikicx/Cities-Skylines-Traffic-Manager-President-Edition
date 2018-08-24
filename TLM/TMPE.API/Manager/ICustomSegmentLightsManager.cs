﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrafficManager.Traffic;
using TrafficManager.Traffic.Enums;
using TrafficManager.TrafficLight;

namespace TrafficManager.Manager {
	public interface ICustomSegmentLightsManager {
		// TODO documentation
		ICustomSegmentLights GetSegmentLights(ushort nodeId, ushort segmentId);
		ICustomSegmentLights GetSegmentLights(ushort segmentId, bool startNode, bool add = true, RoadBaseAI.TrafficLightState lightState = RoadBaseAI.TrafficLightState.Red);
		ICustomSegmentLights GetOrLiveSegmentLights(ushort segmentId, bool startNode);
		void AddNodeLights(ushort nodeId);
		void RemoveNodeLights(ushort nodeId);
		void RemoveSegmentLights(ushort segmentId);
		void RemoveSegmentLight(ushort segmentId, bool startNode);
		bool IsSegmentLight(ushort segmentId, bool startNode);
		void SetLightMode(ushort segmentId, bool startNode, ExtVehicleType vehicleType, LightMode mode);
		bool ApplyLightModes(ushort segmentId, bool startNode, ICustomSegmentLights otherLights);
		bool SetSegmentLights(ushort nodeId, ushort segmentId, ICustomSegmentLights lights);
	}
}
